using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Projet_Finale
{
    internal class Programme
    {
        private string code;
        private string domain;
        private string name;
        private int nbrHeures;

        
        public Programme(string code, string domain, string name, int nbrHeures)
        {
            this.Code = code;
            this.Domain = domain;
            this.Name = name;
            this.NbrHeures = nbrHeures;
        }

        public string Code { get => code; set => code = value; }
        public string Domain { get => domain; set => domain = value; }
        public string Name { get => name; set => name = value; }
        public int NbrHeures { get => nbrHeures; set => nbrHeures = value; }
    }
}
