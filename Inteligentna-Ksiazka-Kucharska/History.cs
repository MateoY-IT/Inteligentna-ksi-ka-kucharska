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
    public partial class History : Form
    {
        SqlConnection connection;
        string connectionString;
        public History()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Inteligentna_Ksiazka_Kucharska.Properties.Settings.PrzepisyConnectionString"].ConnectionString;
        }
        public void popularneprzepisy()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Historia", connection))
            {
                DataTable PrzepisTable = new DataTable();
                adapter.Fill(PrzepisTable);

                listBoxhistoria.ValueMember = "ID_przepisu";
                listBoxhistoria.DisplayMember = "Nazwa";

                listBoxhistoria.DataSource = PrzepisTable;
            }
        }

        private void listBoxwyswietl_SelectedIndexChanged(object sender, EventArgs e)
        {
            string element = listBoxhistoria.GetItemText(listBoxhistoria.SelectedItem);
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(
                $"SELECT * FROM Historia WHERE history_id='{listBoxhistoria.SelectedValue}'",
                connection))
            {
                DataTable PrzepisTable = new DataTable();
                adapter.Fill(PrzepisTable);
                if (PrzepisTable.Rows.Count != 0)
                {
                    listBoxwyswietl.Text = "Instrukcja: " + PrzepisTable.Rows[0]["Instrukcje"].ToString()
                        + Environment.NewLine + "Czas przygotowania: " + PrzepisTable.Rows[0]["Czas_przygotowania"].ToString();
                }

            }
        }

        private void listBoxhistoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void History_Load(object sender, EventArgs e)
        {

        }
    }
}
