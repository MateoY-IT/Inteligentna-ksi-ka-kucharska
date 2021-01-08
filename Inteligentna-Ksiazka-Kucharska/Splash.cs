using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inteligentna_Ksiazka_Kucharska
{
    public partial class Splash : Form
        
    {
        int a = 50;
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (a == 0)
                label1.Text = "Ładowanie....";
            if (a == 10)
                label1.Text = "Ładowanie Systemu Inteligentnej Książki Kucharskiej...";
            if (a == 20)
                label1.Text = "Proszę Czekać....!";
            if (a == 30)
                label1.Text = "Ładowanie Systemu Inteligentnej Książki Kucharskiej...";
            if (a == 40)
                label1.Text = "Proszę Czekać....!";
            if (a == 50)
                label1.Text = "Ładowanie....";
            if (a == 60)
                label1.Text = "Ładowanie Systemu Inteligentnej Książki Kucharskiej...";
            if (a == 70)
                label1.Text = "Proszę Czekać....!";
            if (a == 80)
                label1.Text = "Ładowanie Systemu Inteligentnej Książki Kucharskiej...";
            if (a == 90)
                label1.Text = "Prawie Gotowe...";
            if (a == 95)
                label1.Text = "Gotowe!";

            a += 1;
            if (a >= 100)
            {
                this.Hide();
                timer1.Enabled = false;
                Main mdl = new Main();
                mdl.ShowDialog();
            }
            progressBar1.Value = a;
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }
    }
}
