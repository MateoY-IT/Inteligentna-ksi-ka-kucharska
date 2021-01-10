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
    public partial class Historia : Form
    {
        public Historia()
        {
            InitializeComponent();
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

        }

        private void listaZakupówToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void Historia_Load(object sender, EventArgs e)
        {

        }
    }
}
