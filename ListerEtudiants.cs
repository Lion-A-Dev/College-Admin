using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_sharp_Projet_Finale
{
    public partial class ListerEtudiants : Form
    {
        static int etudCompteur = 0;
        public ListerEtudiants()
        {
            InitializeComponent();
            
        }

        private void ListerEtudiants_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //SELECTION DU PREMIER ELEMENT DANS LA LIST<ETUDIANT>
            etudCompteur = 0;
            if (Inscription.listEtud.Count == 0)
            {
                MessageBox.Show("La Liste est Vide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtListCodeEtud.Text = Inscription.listEtud[0].CodeEtudiant;
            txtListNomEtud.Text = Inscription.listEtud[0].Nom;
            txtListPrEtud.Text = Inscription.listEtud[0].Prenom;
            txtListDateEtud.Text = Inscription.listEtud[0].DateNaissance.ToString();
            txtListCourriel.Text = Inscription.listEtud[0].Courriel;
            txtListCodeProgEtud.Text = Inscription.listEtud[0].ProgrammeCode;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //SELECTION DU SUIVANT DANS LA LIST<ETUDIANT>
            if (Inscription.listEtud.Count == 0)
            {
                MessageBox.Show("La Liste est Vide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (etudCompteur < Inscription.listEtud.Count - 1)
            {
                etudCompteur++;
            }
            txtListCodeEtud.Text = Inscription.listEtud[etudCompteur].CodeEtudiant;
            txtListNomEtud.Text = Inscription.listEtud[etudCompteur].Nom;
            txtListPrEtud.Text = Inscription.listEtud[etudCompteur].Prenom;
            txtListDateEtud.Text = Inscription.listEtud[etudCompteur].DateNaissance.ToString();
            txtListCourriel.Text = Inscription.listEtud[etudCompteur].Courriel;
            txtListCodeProgEtud.Text = Inscription.listEtud[etudCompteur].ProgrammeCode;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //SELECTION DE L'ELEMENT PRECEDENT DANS LA LIST<ETUDIANT>
            if (Inscription.listEtud.Count == 0)
            {
                MessageBox.Show("La Liste est Vide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (etudCompteur > 0)
            {
                etudCompteur--;
            }
            txtListCodeEtud.Text = Inscription.listEtud[etudCompteur].CodeEtudiant;
            txtListNomEtud.Text = Inscription.listEtud[etudCompteur].Nom;
            txtListPrEtud.Text = Inscription.listEtud[etudCompteur].Prenom;
            txtListDateEtud.Text = Inscription.listEtud[etudCompteur].DateNaissance.ToString();
            txtListCourriel.Text = Inscription.listEtud[etudCompteur].Courriel;
            txtListCodeProgEtud.Text = Inscription.listEtud[etudCompteur].ProgrammeCode;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //SELECTION DU DERNIER ELEMENT DANS LA LIST<ETUDIANT>
            if (Inscription.listEtud.Count == 0)
            {
                MessageBox.Show("La Liste est Vide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            etudCompteur = Inscription.listEtud.Count-1;
            txtListCodeEtud.Text = Inscription.listEtud.Last().CodeEtudiant;
            txtListNomEtud.Text = Inscription.listEtud.Last().Nom;
            txtListPrEtud.Text = Inscription.listEtud.Last().Prenom;
            txtListDateEtud.Text = Inscription.listEtud.Last().DateNaissance.ToString();
            txtListCourriel.Text = Inscription.listEtud.Last().Courriel;
            txtListCodeProgEtud.Text = Inscription.listEtud.Last().ProgrammeCode;
        }

        private void btnListRetour_Click(object sender, EventArgs e)
        {
            this.Close();
            Inscription ins = new Inscription();
            ins.Show();
        }

        private void btnListAnnuler_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
            txtListNomEtud.Focus();
        }

        private void btnPrecedent_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
