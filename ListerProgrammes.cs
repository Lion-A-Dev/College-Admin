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
    public partial class ListerProgrammes : Form
    {
        public ListerProgrammes()
        {
            InitializeComponent();
            //LISTER LES PROGRAM DANS UN GRID VIEW
            foreach (Programme programme in Inscription.listProg) 
            {
                gv_ListProg.ColumnCount = 4;
                gv_ListProg.Rows.Add(programme.Code, programme.Domain, programme.Name, programme.NbrHeures);
            }
        }

        private void btnListerRetour_Click(object sender, EventArgs e)
        {
            //RETOUR A LA PAGE PRECEDENTE
            this.Close();
            this.Hide();
            Inscription ins = new Inscription();
            ins.Show();
        }

        private void ListerProgrammes_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
