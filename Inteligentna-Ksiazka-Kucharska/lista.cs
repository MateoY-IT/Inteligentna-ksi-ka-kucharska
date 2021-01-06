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
    public partial class lista : Form
    {
        SqlConnection connection;
        string connectionString;

        public lista()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Inteligentna_Ksiazka_Kucharska.Properties.Settings.PrzepisyConnectionString"].ConnectionString;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttondodaj_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection1 =
                 new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Lista (Nazwa) VALUES ('" + textBox1.Text + "')";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();

            this.DialogResult = DialogResult.OK;
        }

        private void buttonusun_Click(object sender, EventArgs e)
        {
            string nazwa = checkedListBox1.GetItemText(checkedListBox1.SelectedItem);
            SqlConnection sqlConnection1 =
                           new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Lista WHERE Nazwa='" + nazwa + "'";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();

            this.DialogResult = DialogResult.OK;
        }

        private void buttonedytuj_Click(object sender, EventArgs e)
        {
            string nazwa = checkedListBox1.GetItemText(checkedListBox1.SelectedItem);
            SqlConnection sqlConnection1 =
                           new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Lista SET " +
                "Nazwa = '" + textBox1.Text + "', " +
                "WHERE Nazwa = '" + nazwa + "'";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();

            this.DialogResult = DialogResult.OK;
        }
        public void popularnalista()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Lista", connection))
            {
                DataTable ListaTable = new DataTable();
                adapter.Fill(ListaTable);

                checkedListBox1.ValueMember = "lista_ID";

                checkedListBox1.DisplayMember = "Nazwa";

                checkedListBox1.DataSource = ListaTable;
            }
        }
        private void lista_Load(object sender, EventArgs e)
        {
            popularnalista();
        }
    }
}
