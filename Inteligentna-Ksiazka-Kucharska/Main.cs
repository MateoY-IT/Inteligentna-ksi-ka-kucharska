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
    public partial class Main : Form
    {
        SqlConnection connection;
        string connectionString;

        public Main()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["Inteligentna_Ksiazka_Kucharska.Properties.Settings.PrzepisyConnectionString"].ConnectionString;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            popularneprzepisy();
        }

        public void popularneprzepisy()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Przepis", connection))
            {
                DataTable PrzepisTable = new DataTable();
                adapter.Fill(PrzepisTable);

                listbprzepis.ValueMember = "ID_przepisu";
                listbprzepis.DisplayMember = "Nazwa";

                listbprzepis.DataSource = PrzepisTable;
            }
        }

        private void listbprzepis_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listbprzepis_SelectedValueChanged(object sender, EventArgs e)
        {


                string element = listbprzepis.GetItemText(listbprzepis.SelectedItem);
                using (connection = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter(
                    $"SELECT * FROM Przepis WHERE ID_przepisu='{listbprzepis.SelectedValue}'",
                    connection))
                {
                    DataTable PrzepisTable = new DataTable();
                    adapter.Fill(PrzepisTable);
                    if (PrzepisTable.Rows.Count != 0)
                    {
                        textBoxopis.Text = "Instrukcja: " + PrzepisTable.Rows[0]["Instrukcje"].ToString()
                            + Environment.NewLine + "Czas przygotowania: " + PrzepisTable.Rows[0]["Czas_przygotowania"].ToString()
                            + Environment.NewLine + "Zdjecie: " + PrzepisTable.Rows[0]["Zdjecie"].ToString();
                    }

                }
        }

        private void buttondodaj_Click(object sender, EventArgs e)
        {
            Dodaj mdf = new Dodaj();
            DialogResult dR = mdf.ShowDialog();

            if (dR == DialogResult.OK) popularneprzepisy();
        }

        private void buttonusun_Click(object sender, EventArgs e)
        {
            Usun mdf = new Usun();
            DialogResult dR = mdf.ShowDialog();

            if (dR == DialogResult.OK) popularneprzepisy();
        }

        private void buttonedytuj_Click(object sender, EventArgs e)
        {
            Edytuj mdf = new Edytuj();
            DialogResult dR = mdf.ShowDialog();

            if (dR == DialogResult.OK) popularneprzepisy();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Przepis WHERE Nazwa Like '%" + txtSearch.Text + "%'", connection))
            {
                DataTable PrzepisTable = new DataTable();
                adapter.Fill(PrzepisTable);

                listbprzepis.ValueMember = "ID_przepisu";
                listbprzepis.DisplayMember = "Nazwa";
                listbprzepis.DataSource = PrzepisTable;
            }
        }

        private void przepisyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ulubioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void historiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Historia nForm = new Historia();
            nForm.Show();
        }

        private void listaZakupówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Listazak nForm = new Listazak();
            nForm.Show();
        }
    }
}
