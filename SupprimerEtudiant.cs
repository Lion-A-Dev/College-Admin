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

namespace C_sharp_Projet_Finale
{
    public partial class SupprimerEtudiant : Form
    {
        public SupprimerEtudiant()
        {
            InitializeComponent();
        }

        private void txtSuppNomEtud_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSuppEtudRech_Click(object sender, EventArgs e)
        {
            //BOUTTON RECHERCHE
            StreamReader sr = new StreamReader("etudiants.txt");
            string ligne = "";
            bool trouve = false;

            while ((ligne = sr.ReadLine()) != null)
            {
                string[] tab = ligne.Split(';');
                if (tab[0] == txtSuppCodeEtud.Text)
                {
                    txtSuppCodeEtud.Text = tab[0];
                    txtSuppNomEtud.Text = tab[1];
                    txtSuppPreEtud.Text = tab[2];
                    txtSuppDateNaiss.Text = tab[3];
                    txtSuppCourriel.Text = tab[4];
                    txtSuppCodeProgEtud.Text = tab[5];
                    trouve = true;
                    break;
                }
            }
            sr.Close();

            if (!trouve)
            {
                MessageBox.Show("Etudiants non trouvé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach (Control c in Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                    }
                }
                txtSuppCodeEtud.Focus();
            }
        }

        private void btnSuppEtudRetour_Click(object sender, EventArgs e)
        {
            this.Close();
            Inscription ins = new Inscription();
            ins.Show();
        }

        private void btnSuppEtudAnnuler_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void btnSuppEtudiant_Click(object sender, EventArgs e)
        {
            if (txtSuppCodeEtud.Text.Equals("") || txtSuppNomEtud.Text.Equals("") || txtSuppPreEtud.Text.Equals("") || txtSuppCourriel.Text.Equals("") || txtSuppCodeProgEtud.Text.Equals(""))
            {
                MessageBox.Show("Un etudiant ne peut etre supprimer sans le rechercher.");
                return;
            }
            //SUPPRESSION DU FICHIER .TXT
            StreamReader sr = new StreamReader("etudiants.txt");
            StreamWriter sw = new StreamWriter("tempEtud.txt");
            string ligne = "";
            bool trouve = false;

            while ((ligne = sr.ReadLine()) != null)
            {
                string[] tab = ligne.Split(';');
                if (tab[0] == txtSuppCodeEtud.Text)
                {
                    trouve = true;
                    continue;
                }
                sw.WriteLine(ligne);
            }


            //SUPPRESSION DE LA LIST<ETUDIANT> A PARTIR DU FICHIER .TXT
            Inscription.listProg.Clear();
            do
            {
                ligne = sr.ReadLine();
                if (ligne != null)
                {
                    string[] tab = ligne.Split(';');
                    Etudiant student = new Etudiant(tab[0], tab[1], tab[2], DateTime.Parse(tab[3]), tab[4], tab[5]);
                    Inscription.listEtud.Add(student);
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
                File.Delete("etudiants.txt");
                File.Move("tempEtud.txt", "etudiants.txt");

                MessageBox.Show("Etudiants supprimé avec succes", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                foreach (Control c in Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                    }
                }
                txtSuppCodeEtud.Focus();
            }
        }

        private void SupprimerEtudiant_Load(object sender, EventArgs e)
        {

        }
    }
}
