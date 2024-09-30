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
    public partial class SupprimerProgramme : Form
    {
        public SupprimerProgramme()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSupCode.Text = string.Empty;
            txtSupDom.Text = string.Empty;
            txtSupNom.Text = string.Empty;
            txtSupHeures.Text = string.Empty;
            txtSupCode.Focus();
        }

        private void btnSupRetour_Click(object sender, EventArgs e)
        {
            //RETOUR A LA PAGE PRECEDENTE
            this.Close();
            Inscription ins = new Inscription();
            ins.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //BUTTON RECHERCHE
            StreamReader sr = new StreamReader("programmes.txt");
            string ligne = "";
            bool trouve = false;

            while ((ligne = sr.ReadLine()) != null)
            {
                string[] tab = ligne.Split(';');
                if (tab[0] == txtSupCode.Text)
                {
                    txtSupCode.Text = tab[0];
                    txtSupDom.Text = tab[1];
                    txtSupNom.Text = tab[2];
                    txtSupHeures.Text = tab[3];
                    trouve = true;
                    break;
                }
            }

            sr.Close();

            if (!trouve)
            {
                MessageBox.Show("Programme non trouvé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach (Control c in Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                    }
                }
                txtSupCode.Focus();
            }
        }


        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            //SUPPRESSION DU FICHIER .TXT
            if (txtSupCode.Text.Equals("") || txtSupDom.Text.Equals("") || txtSupNom.Text.Equals("") || txtSupHeures.Text.Equals(""))
            {
                MessageBox.Show("Un programme ne peut etre supprimer sans le rechercher.");
                return;
            }
            foreach(Etudiant student in Inscription.listEtud)
            {
                if (student.ProgrammeCode.Equals(txtSupCode.Text))
                {
                    MessageBox.Show("Un programme ne peut etre supprimer si un eleve est encore inscrit dedans");
                    foreach (Control c in Controls)
                    {
                        if (c is TextBox)
                        {
                            c.Text = "";
                        }
                    }
                    txtSupCode.Focus();
                    return;
                }
            }


            StreamReader sr = new StreamReader("programmes.txt");
            StreamWriter sw = new StreamWriter("temp.txt");
            string ligne = "";
            bool trouve = false;

            while ((ligne = sr.ReadLine()) != null)
            {
                string[] tab = ligne.Split(';');
                if (tab[0] == txtSupCode.Text)
                {
                    trouve = true;
                    continue;
                }
                sw.WriteLine(ligne);
            }

            
            //SUPPRESSION DE LA LIST<PROGRAMME> A PARTIR DU FICHIER .TXT
            Inscription.listProg.Clear();
            do
            {
                ligne = sr.ReadLine();
                if (ligne != null)
                {
                    string[] tab = ligne.Split(';');
                    Programme nProgramme = new Programme(tab[0], tab[1], tab[2], int.Parse(tab[3]));
                    Inscription.listProg.Add(nProgramme);
                }
                if (ligne == String.Empty)
                {
                    continue;
                }
            } while (!trouve);
            sr.Close();
            sw.Close();


            if (trouve)
            {
                File.Delete("programmes.txt");
                File.Move("temp.txt", "programmes.txt");

                MessageBox.Show("Programme supprimé avec succes", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                foreach (Control c in Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                    }
                }
                txtSupCode.Focus();
            }
        }

        private void SupprimerProgramme_Load(object sender, EventArgs e)
        {

        }
    }
}
