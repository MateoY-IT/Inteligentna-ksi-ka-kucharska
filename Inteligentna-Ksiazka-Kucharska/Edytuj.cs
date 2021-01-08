﻿using System;
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
        PrzepisyDatabaseDataContext DatabaseDataContext = new PrzepisyDatabaseDataContext();
        Przepis SelectedPrzepis;
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
        private void loadPrzepis()
        {
          foreach( Przepis w in DatabaseDataContext.Przepis)
            {
                listBoxwyswietl.Items.Add(w);
            }
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

        private void banuluj_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBoxwyswietl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxwyswietl.SelectedItems.Count== 1)
            {
                listBoxwyswietl.Enabled = false;
                SelectedPrzepis = listBoxwyswietl.SelectedItem as Przepis;
                textBoxTitle.Text = SelectedPrzepis.Nazwa;
                textBprzygotowanie.Text = SelectedPrzepis.Instrukcje;
            }
        }

        private void bedytuj_Click(object sender, EventArgs e)
        {
            string nazwa = listBoxwyswietl.GetItemText(listBoxwyswietl.SelectedItem);
            SqlConnection sqlConnection1 =
                           new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Przepis SET " +
                "Nazwa = '" + textBoxTitle.Text + "', " +
                "Instrukcje = '" + textBprzygotowanie.Text + "', " +
                "Zdjecie = '" + pictureBox1.ImageLocation + "' " +
                "WHERE Nazwa = '" + nazwa + "'";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();

            this.DialogResult = DialogResult.OK;
        }
    }
}
