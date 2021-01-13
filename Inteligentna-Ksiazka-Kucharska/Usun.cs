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
    public partial class Usun : Form
    {
        PrzepisyDataContext PrzepisyDC = new PrzepisyDataContext();
        SqlConnection connection;
        string connectionString;
        public Usun()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Inteligentna_Ksiazka_Kucharska.Properties.Settings.PrzepisyConnectionString"].ConnectionString;
        }

        private void Usun_Load(object sender, EventArgs e)
        {
            popularneprzepisy();
        }

        public void popularneprzepisy()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Przepisy", connection))
            {
                DataTable PrzepisTable = new DataTable();
                adapter.Fill(PrzepisTable);

                listBox1.ValueMember = "ID_przepisu";
                listBox1.DisplayMember = "Nazwa";

                listBox1.DataSource = PrzepisTable;
            }
        }
        private void banuluj_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bpotwierdz_Click(object sender, EventArgs e)
        {
            string nazwa = listBox1.GetItemText(listBox1.SelectedItem);
            SqlConnection sqlConnection1 =
                           new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Przepisy WHERE Nazwa='" + nazwa + "'";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();

            this.DialogResult = DialogResult.OK;

        }
    }
}
