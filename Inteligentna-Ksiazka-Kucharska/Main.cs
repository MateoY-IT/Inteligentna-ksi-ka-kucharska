﻿using System;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void buttonArtykol_Click(object sender, EventArgs e)
        {
            userControl11.BringToFront();
        }

        private void buttonPrzepisy_Click(object sender, EventArgs e)
        {
            
        }
    }
}