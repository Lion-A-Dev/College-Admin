namespace C_sharp_Projet_Finale
{
    partial class ListerProgrammes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gv_ListProg = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domaine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Heures = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListerRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ListProg)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_ListProg
            // 
            this.gv_ListProg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_ListProg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Domaine,
            this.Nom,
            this.Heures});
            this.gv_ListProg.Location = new System.Drawing.Point(72, 65);
            this.gv_ListProg.Name = "gv_ListProg";
            this.gv_ListProg.RowHeadersWidth = 51;
            this.gv_ListProg.RowTemplate.Height = 24;
            this.gv_ListProg.Size = new System.Drawing.Size(658, 298);
            this.gv_ListProg.TabIndex = 0;
            this.gv_ListProg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.MinimumWidth = 6;
            this.Code.Name = "Code";
            this.Code.Width = 125;
            // 
            // Domaine
            // 
            this.Domaine.HeaderText = "Domaine";
            this.Domaine.MinimumWidth = 6;
            this.Domaine.Name = "Domaine";
            this.Domaine.Width = 125;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 6;
            this.Nom.Name = "Nom";
            this.Nom.Width = 125;
            // 
            // Heures
            // 
            this.Heures.HeaderText = "Nombre d\'heures";
            this.Heures.MinimumWidth = 6;
            this.Heures.Name = "Heures";
            this.Heures.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des programmes du College";
            // 
            // btnListerRetour
            // 
            this.btnListerRetour.Location = new System.Drawing.Point(359, 386);
            this.btnListerRetour.Name = "btnListerRetour";
            this.btnListerRetour.Size = new System.Drawing.Size(102, 35);
            this.btnListerRetour.TabIndex = 2;
            this.btnListerRetour.Text = "Retour";
            this.btnListerRetour.UseVisualStyleBackColor = true;
            this.btnListerRetour.Click += new System.EventHandler(this.btnListerRetour_Click);
            // 
            // ListerProgrammes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListerRetour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gv_ListProg);
            this.Name = "ListerProgrammes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscription College - Lister programme";
            this.Load += new System.EventHandler(this.ListerProgrammes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_ListProg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_ListProg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListerRetour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domaine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Heures;
    }
}