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

        private void popularneprzepisy()
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
                            + Environment.NewLine + "Czas przygotowania: " + PrzepisTable.Rows[0]["Czas_przygotowania"].ToString();
                    }

                }
        }

        private void buttondodaj_Click(object sender, EventArgs e)
        {
            Dodaj mdf = new Dodaj();
            mdf.ShowDialog();

        }
    }
}
