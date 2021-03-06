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
using System.IO;

namespace Inteligentna_Ksiazka_Kucharska
{
    public partial class Dodaj : Form
    {
        PrzepisyDataContext DatabaseDataContext = new PrzepisyDataContext();
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

            List<string> zaznaczoneProduktyLista = new List<string>();

            foreach (DataRowView indexChecked in cLBSkladniki.CheckedItems)
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

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Przepisy (Nazwa, Skladniki, Czas_przygotowania, Instrukcje, Zdjecie) VALUES ('" + textBtytul.Text + "', '" + produktyValue + "', '" + nczasp.Value + "', '" + textBprzygotowanie.Text + "', '" + pictureBox1.ImageLocation + "')";
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

                cLBSkladniki.ValueMember = "ID_produktu";
                cLBSkladniki.DisplayMember = "Nazwa";

                cLBSkladniki.DataSource = ProduktTable;
            }
        }

        private void banuluj_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void Dodaj_Load(object sender, EventArgs e)
        {
            popularneprodukty();
            cLBSkladniki.DisplayMember = "Nazwa";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
