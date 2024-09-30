using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace C_sharp_Projet_Finale
{
    public partial class Login : Form
    {
        static List<Agents> agents = new List<Agents>();
        public Login()
        {
            InitializeComponent();
            agents.Add(new Agents("mlazar", "1234"));
            agents.Add(new Agents("larar", "0000"));
            agents.Add(new Agents("crosemont", "2020"));

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_conn_Click(object sender, EventArgs e)
        {
            //VERIFICATION DE L'ENTRER PAR L'UTILISATEUR FACE AU OBJETS DANS LA LIST AGENTS.
            bool logAccepter = false;

            foreach (Agents ag in agents)
            {
                if (txtUser.Text.Equals(ag.Username) && txtPass.Text.Equals(ag.Password))
                {
                    logAccepter = true;
                    Inscription inscription = new Inscription();
                    inscription.Show();
                    this.Hide();
                    break;
                }
            }

            if (!logAccepter)
            {
                MessageBox.Show("Erreur de nom ou de mot de passe", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Text = "";
                txtPass.Text = "";
                txtUser.Focus();
            }
        }


        private void btn_quit_auth_Click(object sender, EventArgs e)
        {
            //BUTTON POUR QUITTER
            DialogResult reponse = MessageBox.Show("voulez vous quitter ? ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (reponse == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
