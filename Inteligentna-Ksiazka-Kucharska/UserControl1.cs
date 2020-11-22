using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inteligentna_Ksiazka_Kucharska
{
    public partial class UserControl1 : UserControl
    {
        DataClasses1DataContext DatabaseDC = new DataClasses1DataContext();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadArtykuly();
        }

        private void LoadArtykuly()
        {
            foreach (Artykul w in DatabaseDC.Artykul)
            {
                listBox1.Items.Add(w);
            }
        }
    }
}
