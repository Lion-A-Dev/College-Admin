using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Projet_Finale
{
    internal class Agents
    {
        private string username;
        private string password;

        public Agents(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
