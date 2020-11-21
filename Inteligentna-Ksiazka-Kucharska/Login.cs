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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textlogin_Enter(object sender, EventArgs e)
        {
            if(textlogin.Text=="Login"){
                textlogin.Text = "";
                textlogin.ForeColor = Color.LightGray;

            }
        }

        private void textlogin_Leave(object sender, EventArgs e)
        {
            if (textlogin.Text == "")
            {
                textlogin.Text = "Login";
                textlogin.ForeColor = Color.DarkGray;
            }
        }

        private void texthaslo_Enter(object sender, EventArgs e)
        {
            if (texthaslo.Text=="Hasło")
            {
                texthaslo.Text = "";
                texthaslo.ForeColor = Color.LightGray;
                texthaslo.UseSystemPasswordChar = true;

            }
        }

        private void texthaslo_Leave(object sender, EventArgs e)
        {
            if (texthaslo.Text=="")
            {
                texthaslo.Text = "Hasło";
                texthaslo.ForeColor = Color.DarkGray;
                texthaslo.UseSystemPasswordChar = false;
            }
        }

        private void buttonzaloguj_Click(object sender, EventArgs e)
        {
            if (textlogin.Text != "Login")
            {
                if (texthaslo.Text != "Hasło") { }
                else msgError("Proszę podaj hasło.");

            }
            else msgError("Proszę podać nazwę użytkownika.");


        }
        private void msgError(string msg)
        {
            ErrorMessage.Text = "   "+msg;
            ErrorMessage.Visible = true;
        }
    }
}
