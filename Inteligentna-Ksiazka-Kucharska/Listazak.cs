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
    public partial class Listazak : Form
    {
        SqlConnection connection;
        string connectionString;

        public Listazak()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Inteligentna_Ksiazka_Kucharska.Properties.Settings.PrzepisyConnectionString"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        public void popularneprzepisy()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Lista", connection))
            {
                DataTable PrzepisTable = new DataTable();
                adapter.Fill(PrzepisTable);


                cLiBwyswietl.ValueMember = "Lista_ID";
                cLiBwyswietl.DisplayMember = "Nazwa";

                cLiBwyswietl.DataSource = PrzepisTable;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
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

        private void btnUsun_Click(object sender, EventArgs e)
        {
            string nazwa = cLiBwyswietl.GetItemText(cLiBwyswietl.SelectedItem);
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

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            string nazwa = cLiBwyswietl.GetItemText(cLiBwyswietl.SelectedItem);
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

        private void przepisyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main nForm = new Main();
            nForm.Show();
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

        }
    }
}
