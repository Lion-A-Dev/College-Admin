using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Projet_Finale
{
    internal class Etudiant
    {
        private string codeEtudiant;
        private string nom;
        private string prenom;
        private DateTime dateNaissance;
        private string courriel;
        private string programmeCode;


        public Etudiant(string codeEtudiant, string nom, string prenom, DateTime dateNaissance, string courriel, string programmeCode)
        {
            this.CodeEtudiant = codeEtudiant;
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateNaissance = dateNaissance;
            this.Courriel = courriel;
            this.ProgrammeCode = programmeCode;
            this.CodeEtudiant = codeEtudiant;
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateNaissance = dateNaissance;
            this.Courriel = courriel;
            this.ProgrammeCode = programmeCode;
        }

        public string CodeEtudiant { get => codeEtudiant; set => codeEtudiant = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public DateTime DateNaissance { get => dateNaissance; set => dateNaissance = value; }
        public string Courriel { get => courriel; set => courriel = value; }
        public string ProgrammeCode { get => programmeCode; set => programmeCode = value; }
    }
}
