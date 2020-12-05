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
            using(connection = new SqlConnection(connectionString))
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
    }
}
