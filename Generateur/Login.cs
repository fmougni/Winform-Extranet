using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Generateur
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Identifiant_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CLOUD_Click(object sender, EventArgs e)
        {

        }
        //se connecter
        private void button1_Click(object sender, EventArgs e)
        {

            Authentification Auth = new Authentification();

            if (id.Text == "" || MotdePasse.Text == "")
            {
                InfoLog.Text = "Veuillez Remplir les champs Identifiant et Mot de passe !";
                InfoLog.ForeColor = System.Drawing.Color.Red;
            }
            else
                try
                {
                    Auth.AuthentificationUtilisateur(id.Text, MotdePasse.Text);
                    if (Utilisateur.TokenSession == null)
                    {
                        InfoLog.Text = "Identifiant ou mot de passe inconnue";
                        InfoLog.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        RedirectLogin(new Form1());
                    }
                        /* test en dur*/
                        //if (id.Text != "admin" || MotdePasse.Text != "admin")
                        //{
                        //    InfoLog.Text = "Identifiant ou mot de passe inconnue";
                        //    InfoLog.ForeColor = System.Drawing.Color.Red;
                        //}
                        //else
                        //{
                        //    RedirectLogin(new Form1());

                        //}
                    }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

        }

        private void RedirectLogin(Form childForm)
        {
            
            childForm.Show(); this.Hide();
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
