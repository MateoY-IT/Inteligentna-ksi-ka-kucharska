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
    public partial class Dodaj : Form
    {
        SqlConnection connection;
        string connectionString;


        public Dodaj()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Inteligentna_Ksiazka_Kucharska.Properties.Settings.PrzepisyConnectionString"].ConnectionString;
        }

        private void bdodaj_Click(object sender, EventArgs e)
        {

           SqlConnection sqlConnection1 =
                            new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Przepis (Nazwa, Instrukcje, Zdjecie) VALUES ('"+ textBtytul.Text + "', '"+ textBprzygotowanie.Text +"', '"+ pictureBox1.ImageLocation+ "')";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();

            this.DialogResult = DialogResult.OK;
        }
        public void popularneprodukty()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Produkt", connection))
            {
                DataTable ProduktTable = new DataTable();
                adapter.Fill(ProduktTable);

                listBskladniki.ValueMember = "ID_produktu";
                listBskladniki.DisplayMember = "Nazwa";

                listBskladniki.DataSource = ProduktTable;
            }
        }
        private void banuluj_Click(object sender, EventArgs e)
        {
            Close();
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

        private void Dodaj_Load(object sender, EventArgs e)
        {
            popularneprodukty();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
