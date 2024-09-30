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
    public partial class AjoutProgramme : Form
    {
        public AjoutProgramme()
        {
            InitializeComponent();
            
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            this.Close();
            Inscription ins = new Inscription();
            ins.Show();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            txtCodeProg.Text = "";
            txtDomainProg.Text = "";
            txtNomProg.Text = "";
            txtHeureProg.Text = "";
            txtCodeProg.Focus();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            //VERIFICATION QUE LE CODE EXISTE DEJA
            for (int i = 0; i< Inscription.listProg.Count; i++)
            {
                if (txtCodeProg.Text == Inscription.listProg[i].Code)
                {
                    MessageBox.Show("Ce Code est dejas utiliser", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodeProg.Text = "";
                    txtDomainProg.Text = "";
                    txtNomProg.Text = "";
                    txtHeureProg.Text = "";
                    txtCodeProg.Focus();
                    return;
                }
            }
            //VERIFICATION QUE LES CHAMPS NE SONT PAS VIDES
            if (txtCodeProg.Text.Equals("") || txtDomainProg.Text.Equals("") || txtNomProg.Text.Equals("") || txtHeureProg.Text.Equals(""))
            {
                MessageBox.Show("Un programme ne peut etre ajoute sans remplir toutes les cases.");
            }
            else
            {
                //VERIFICATION QUE L'ENTRER DES HEURES EST BIEN UN NOMBRE
                int heures;
                if (!int.TryParse(txtHeureProg.Text, out heures))
                {
                    MessageBox.Show("Veuillez entrer un nombre valide pour le nombre d'heures.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHeureProg.Focus();
                    return; // Exit the method if the hours input is not a valid integer
                }

                try
                {
                    //AJOUT A UN FICHIER .TXT
                    StreamWriter sw = new StreamWriter("programmes.txt", true);
                    string progFileContent = txtCodeProg.Text.ToLower().Trim() + ";" + txtDomainProg.Text.ToLower().Trim() + ";" + txtNomProg.Text.ToLower().Trim() + ";" + txtHeureProg.Text.ToLower().Trim();
                    sw.WriteLine(progFileContent);
                    sw.Close();

                    MessageBox.Show("Programme ajoute avec succes.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foreach (Control c in Controls)
                    {
                        if (c is TextBox)
                        {
                            c.Text = "";
                        }
                    }
                    txtCodeProg.Focus();


                    //AJOUT DES LIGNE DU FICHIER .TXT DANS LA LIST<PROGRAMME>
                    StreamReader sr = new StreamReader("programmes.txt");
                    string ligne = "";

                    bool trouve = false;
                    do
                    {
                        ligne = sr.ReadLine();
                        if (ligne != null)
                        {
                            string[] tab = ligne.Split(';');
                            Programme nProgramme = new Programme(tab[0], tab[1], tab[2], int.Parse(tab[3]));
                            Inscription.listProg.Add(nProgramme);
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
                    MessageBox.Show("Une erreur est survenue lors de l'ajout du programme. Veuillez réessayer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void AjoutProgramme_Load(object sender, EventArgs e)
        {

        }
    }
}
