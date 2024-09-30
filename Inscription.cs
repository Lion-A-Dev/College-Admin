using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.LinkLabel;

namespace C_sharp_Projet_Finale
{
    public partial class Inscription : Form
    {
        internal static List<Programme> listProg = new List<Programme>();
        internal static List<Etudiant> listEtud = new List<Etudiant>();
        public Inscription()
        {
            InitializeComponent();
            //UPDATE DE LA PAGE COUVERTURE DE L'INSCRIPTION AINSI
            //QUE LA MISE A JOUR DES LISTES CI-DESSUS
            if (File.Exists("programmes.txt"))
            {
                listProg.Clear();
                StreamReader sr = new StreamReader("programmes.txt");
                string progLigne = "";
                bool progTrouve = false;
                do
                {
                    progLigne = sr.ReadLine();
                    if (progLigne != null)
                    {
                        string[] progTab = progLigne.Split(';');
                        Programme nProgramme = new Programme(progTab[0], progTab[1], progTab[2], int.Parse(progTab[3]));
                        listProg.Add(nProgramme);
                    }
                    if (progLigne == null)
                    {
                        progTrouve = true;
                    }
                    int nbrProg = listProg.Count;
                    lblProgrammeDispo.Text = "Il y a " + nbrProg + " programme disponibles au college!";
                } while (!progTrouve);
                sr.Close();
            }

            if (File.Exists("etudiants.txt"))
            {
                listEtud.Clear();
                StreamReader esr = new StreamReader("etudiants.txt");
                string etudLigne = "";
                bool etudTrouve = false;
                do
                {
                    etudLigne = esr.ReadLine();
                    if (etudLigne != null)
                    {
                        string[] etudTab = etudLigne.Split(';');
                        Etudiant nEtudiant = new Etudiant(etudTab[0], etudTab[1], etudTab[2], DateTime.Parse(etudTab[3]), etudTab[4], etudTab[5]);
                        listEtud.Add(nEtudiant);
                    }
                    if (etudLigne == null)
                    {
                        etudTrouve = true;
                    }
                    int nbrEtud = listEtud.Count;
                    lblEtudiantIns.Text = "Il y a " + nbrEtud + " Etudiants inscrits";
                } while (!etudTrouve);
                esr.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ajouterProgrammeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OUVERTURE DE LA FORM AJOUTER PROGRAMME
            this.Close();
            AjoutProgramme addProg = new AjoutProgramme();
            addProg.ShowDialog();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //QUITTER L'APPLI
            Application.Exit();
        }

        private void supprimerProgrammeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OUVERTURE DE LA FORM SUPPRIMER PROGRAMME
            this.Close();
            SupprimerProgramme suprimeProg = new SupprimerProgramme();
            suprimeProg.ShowDialog();

        }

        private void listerProgrammeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OUVERTURE DE LA FORM LISTER PROGRAMME
            this.Close();
            ListerProgrammes lister = new ListerProgrammes();
            lister.ShowDialog();

        }

        private void Inscription_Load(object sender, EventArgs e)
        {
            
        }

        private void lblProgrammeDispo_Click(object sender, EventArgs e)
        {

        }

        private void ajouterEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OUVERTURE DE LA FORM AJOUTER ETUDIANT
            this.Close();
            AjoutEtudiant ajoutEtudForm = new AjoutEtudiant();
            ajoutEtudForm.ShowDialog();
        }

        private void supprimerEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OUVERTURE DE LA FORM SUPPRIMER ETUDIANT
            this.Close();
            SupprimerEtudiant suppEtud = new SupprimerEtudiant();
            suppEtud.ShowDialog();
        }

        private void listerEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OUVERTURE DE LA FORM LISTER ETUDIANT
            this.Close();
            ListerEtudiants listerEtud = new ListerEtudiants();
            listerEtud.ShowDialog();
        }
    }
}
