using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace C_sharp_Projet_Finale
{
    public partial class AjoutEtudiant : Form
    {
        public AjoutEtudiant()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouEtudAnnuler_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
            cbEtudProgCode.Text = "";
            txtNomEtud.Focus();
        }

        private void btnAjoutEtudRetour_Click(object sender, EventArgs e)
        {
            this.Close();
            Inscription ins = new Inscription();
            ins.Show();
        }

        //METHODE POUR CALCULER L'AGE
        private int calculerAge(DateTime datNaiss)
        {
            
            DateTime aujourdhui = DateTime.Today;
            int age = aujourdhui.Year - datNaiss.Year;

            if (datNaiss.Date > aujourdhui.AddYears(-age)) age--;

            return age;

        }

        private void btnAjoutEtudAjouter_Click(object sender, EventArgs e)
        {
            //VERFICATION QUE L'ETDIANT N'EXIST PAS DEJA
            foreach (Etudiant etudiant in Inscription.listEtud)
            {
                if (txtNomEtud.Text.Equals(etudiant.Nom) &&
                    txtPreEtud.Text.Equals(etudiant.Prenom))
                {
                    MessageBox.Show("Cet etudiant est deja inscrit dans un program");
                    foreach (Control c in Controls)
                    {
                        if (c is TextBox)
                        {
                            c.Text = "";
                        }
                    }
                    cbEtudProgCode.Text = "";
                    dtpNaissance.Value = DateTime.Today;
                    txtNomEtud.Focus();
                    return;
                }
            }

            //VALIDATION DES ESPACES VIDE
            if ( txtNomEtud.Text.Equals("") || txtPreEtud.Text.Equals("")
                || txtCourriel.Text.Equals("") || cbEtudProgCode.Text.Equals(""))
            {
                MessageBox.Show("Un Etudiant ne peut etre ajoute sans remplir toutes les cases.");
                foreach (Control c in Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                    }
                }
                cbEtudProgCode.Text = "";
                txtNomEtud.Focus();
                return;
            }
            else
            {
                //VALIDATION DU REGEX POUR LE COURRIEL
                string courrielPatron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!Regex.IsMatch(txtCourriel.Text, courrielPatron))
                {
                    MessageBox.Show("Erreur, le courriel doit suivre un format valide");
                    txtCourriel.Focus();
                    return;
                }

                //VALIDATION DE LA DATE DE NAISSANCE
                DateTime dateChoisi = dtpNaissance.Value;
                int age = calculerAge(dateChoisi);
                if (age < 18 || age > 65)
                {
                    MessageBox.Show("Veuillez entrer une date valide SVP", "Mauvaise Date" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foreach (Control c in Controls)
                    {
                        if (c is TextBox)
                        {
                            c.Text = "";
                        }
                    }
                    dtpNaissance.Focus();
                    dtpNaissance.Value = DateTime.Today;
                    return;
                }

                try
                {
                    //AJOUT A UN FICHIER .TXT
                    txtCodeEtud.Text = txtNomEtud.Text.Substring(0, 3) + txtPreEtud.Text.Substring(0, 1);
                    StreamWriter sw = new StreamWriter("etudiants.txt", true);
                    string etudFileContent = txtCodeEtud.Text.ToLower().Trim() + ";" + txtNomEtud.Text.ToLower().Trim() + ";" + txtPreEtud.Text.ToLower().Trim() + ";" + dtpNaissance.Text.ToLower().Trim() + ";" + txtCourriel.Text.ToLower().Trim() + ";" + cbEtudProgCode.Text.ToLower().Trim();
                    sw.WriteLine(etudFileContent);
                    sw.Close();

                    MessageBox.Show("Etudiants ajoute avec succes.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foreach (Control c in Controls)
                    {
                        if (c is TextBox)
                        {
                            c.Text = "";
                        }
                    }
                    cbEtudProgCode.Text = "";
                    dtpNaissance.Value = DateTime.Today;
                    txtNomEtud.Focus();


                    //AJOUT DES LIGNE DU FICHIER .TXT DANS LA LIST<PROGRAMME>
                    StreamReader sr = new StreamReader("etudiants.txt");
                    string ligne = "";

                    bool trouve = false;
                    do
                    {
                        ligne = sr.ReadLine();
                        if (ligne != null)
                        {
                            string[] tab = ligne.Split(';');
                            Etudiant student = new Etudiant(tab[0], tab[1], tab[2], DateTime.Parse(tab[3]), tab[4], tab[5]);
                            Inscription.listEtud.Add(student);
                        }
                        if (ligne == null)
                        {
                            trouve = true;
                        }
                    } while (!trouve);
                    sr.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue lors de l'ajout de l'etudiant. Veuillez réessayer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtCodeEtud_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbEtudProgCode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AjoutEtudiant_Load(object sender, EventArgs e)
        {
            foreach (Programme name in Inscription.listProg)
            {
                cbEtudProgCode.Items.Add(name.Code);
            }
        }
    }
}
