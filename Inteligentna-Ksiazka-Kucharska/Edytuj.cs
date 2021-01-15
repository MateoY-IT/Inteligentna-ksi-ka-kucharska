using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Inteligentna_Ksiazka_Kucharska
{
    public partial class Edytuj : Form
    {

        PrzepisyDataContext DatabaseDataContext = new PrzepisyDataContext();
        Przepisy SelectedPrzepis;
        SqlConnection connection;
        string connectionString;

        public Edytuj()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Inteligentna_Ksiazka_Kucharska.Properties.Settings.PrzepisyConnectionString"].ConnectionString;
        }
       
        private void Edytuj_Load(object sender, EventArgs e)
        {
            loadPrzepis();
            listBoxwyswietl.DisplayMember = "Nazwa";
            popularneprodukty();
            CLBSkladniki.DisplayMember = "Nazwa";
        }
        public void popularneprodukty()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Produkt", connection))
            {
                DataTable ProduktTable = new DataTable();
                adapter.Fill(ProduktTable);

                CLBSkladniki.ValueMember = "Id_produktu";
                CLBSkladniki.DisplayMember = "Nazwa";

                CLBSkladniki.DataSource = ProduktTable;
            }
        }
        private void loadPrzepis()
        {
          foreach( Przepisy w in DatabaseDataContext.Przepisies)
            {
                listBoxwyswietl.Items.Add(w);
            }
        }

        private void banuluj_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBoxwyswietl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxwyswietl.SelectedItems.Count== 1)
            {
                //listBoxwyswietl.Enabled = false;
                SelectedPrzepis = listBoxwyswietl.SelectedItem as Przepisy;
                textBoxTitle.Text = SelectedPrzepis.Nazwa;
                textBprzygotowanie.Text = SelectedPrzepis.Instrukcje;
                pictureBox1.ImageLocation = SelectedPrzepis.Zdjecie.ToString();
                nczasp.Value = SelectedPrzepis.Czas_przygotowania.Value;
            }
        }

        private void bedytuj_Click(object sender, EventArgs e)
        {
            string nazwa = listBoxwyswietl.GetItemText(listBoxwyswietl.SelectedItem);
            SqlConnection sqlConnection1 =
                           new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;

            List<string> zaznaczoneProduktyLista = new List<string>();

            foreach (DataRowView indexChecked in CLBSkladniki.CheckedItems)
            {
                zaznaczoneProduktyLista.Add(indexChecked.Row.ItemArray[1].ToString());
            }

            string[] zaznaczoneProdukty = zaznaczoneProduktyLista.ToArray();

            string produktyValue = "";

            foreach (string produkt in zaznaczoneProdukty)
            {
                produktyValue += produkt;
                if (produkt != zaznaczoneProdukty.Last())
                {
                    produktyValue += ", ";
                }
            }

            cmd.CommandText = "update Przepisy SET " +
                "Nazwa = '" + textBoxTitle.Text + "', " +
                "Skladniki = '" + produktyValue + "', " +
                "Instrukcje = '" + textBprzygotowanie.Text + "', " +
                "Czas_przygotowania = '" + nczasp.Value + "', " +
                "Zdjecie = '" + pictureBox1.ImageLocation + "' " +
                "WHERE Nazwa = '" + nazwa + "'";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();

            this.DialogResult = DialogResult.OK;
        }

        private void bwybierz_Click(object sender, EventArgs e)
        {
            String lokalizacjaobrazu = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Pliki jpg(*.jpg)|*.jpg| Pliki png(*.png)|*.png| Wszystkie pliki(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    lokalizacjaobrazu = dialog.FileName;

                    pictureBox1.ImageLocation = lokalizacjaobrazu;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Błąd");
            }
        }
    }
}
