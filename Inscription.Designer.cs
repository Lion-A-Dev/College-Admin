namespace C_sharp_Projet_Finale
{
    partial class Inscription
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEtudiantIns = new System.Windows.Forms.Label();
            this.lblProgrammeDispo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterProgrammeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerProgrammeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listerProgrammeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterEtudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerEtudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listerEtudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::C_sharp_Projet_Finale.Properties.Resources.Capture;
            this.pictureBox1.Location = new System.Drawing.Point(105, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblEtudiantIns
            // 
            this.lblEtudiantIns.AutoSize = true;
            this.lblEtudiantIns.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtudiantIns.Location = new System.Drawing.Point(323, 116);
            this.lblEtudiantIns.Name = "lblEtudiantIns";
            this.lblEtudiantIns.Size = new System.Drawing.Size(190, 22);
            this.lblEtudiantIns.TabIndex = 1;
            this.lblEtudiantIns.Text = "Etudiants Inscrits";
            this.lblEtudiantIns.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblProgrammeDispo
            // 
            this.lblProgrammeDispo.AutoSize = true;
            this.lblProgrammeDispo.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgrammeDispo.Location = new System.Drawing.Point(323, 194);
            this.lblProgrammeDispo.Name = "lblProgrammeDispo";
            this.lblProgrammeDispo.Size = new System.Drawing.Size(230, 22);
            this.lblProgrammeDispo.TabIndex = 2;
            this.lblProgrammeDispo.Text = "Programmes disponibles";
            this.lblProgrammeDispo.Click += new System.EventHandler(this.lblProgrammeDispo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmeToolStripMenuItem,
            this.etudiantToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programmeToolStripMenuItem
            // 
            this.programmeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterProgrammeToolStripMenuItem,
            this.supprimerProgrammeToolStripMenuItem,
            this.listerProgrammeToolStripMenuItem});
            this.programmeToolStripMenuItem.Name = "programmeToolStripMenuItem";
            this.programmeToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.programmeToolStripMenuItem.Text = "Programme";
            // 
            // ajouterProgrammeToolStripMenuItem
            // 
            this.ajouterProgrammeToolStripMenuItem.Name = "ajouterProgrammeToolStripMenuItem";
            this.ajouterProgrammeToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.ajouterProgrammeToolStripMenuItem.Text = "Ajouter Programme";
            this.ajouterProgrammeToolStripMenuItem.Click += new System.EventHandler(this.ajouterProgrammeToolStripMenuItem_Click);
            // 
            // supprimerProgrammeToolStripMenuItem
            // 
            this.supprimerProgrammeToolStripMenuItem.Name = "supprimerProgrammeToolStripMenuItem";
            this.supprimerProgrammeToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.supprimerProgrammeToolStripMenuItem.Text = "Supprimer Programme";
            this.supprimerProgrammeToolStripMenuItem.Click += new System.EventHandler(this.supprimerProgrammeToolStripMenuItem_Click);
            // 
            // listerProgrammeToolStripMenuItem
            // 
            this.listerProgrammeToolStripMenuItem.Name = "listerProgrammeToolStripMenuItem";
            this.listerProgrammeToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.listerProgrammeToolStripMenuItem.Text = "Lister Programme";
            this.listerProgrammeToolStripMenuItem.Click += new System.EventHandler(this.listerProgrammeToolStripMenuItem_Click);
            // 
            // etudiantToolStripMenuItem
            // 
            this.etudiantToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterEtudiantToolStripMenuItem,
            this.supprimerEtudiantToolStripMenuItem,
            this.listerEtudiantToolStripMenuItem});
            this.etudiantToolStripMenuItem.Name = "etudiantToolStripMenuItem";
            this.etudiantToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.etudiantToolStripMenuItem.Text = "Etudiant";
            // 
            // ajouterEtudiantToolStripMenuItem
            // 
            this.ajouterEtudiantToolStripMenuItem.Name = "ajouterEtudiantToolStripMenuItem";
            this.ajouterEtudiantToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ajouterEtudiantToolStripMenuItem.Text = "Ajouter Etudiant";
            this.ajouterEtudiantToolStripMenuItem.Click += new System.EventHandler(this.ajouterEtudiantToolStripMenuItem_Click);
            // 
            // supprimerEtudiantToolStripMenuItem
            // 
            this.supprimerEtudiantToolStripMenuItem.Name = "supprimerEtudiantToolStripMenuItem";
            this.supprimerEtudiantToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.supprimerEtudiantToolStripMenuItem.Text = "Supprimer Etudiant";
            this.supprimerEtudiantToolStripMenuItem.Click += new System.EventHandler(this.supprimerEtudiantToolStripMenuItem_Click);
            // 
            // listerEtudiantToolStripMenuItem
            // 
            this.listerEtudiantToolStripMenuItem.Name = "listerEtudiantToolStripMenuItem";
            this.listerEtudiantToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listerEtudiantToolStripMenuItem.Text = "Lister Etudiant";
            this.listerEtudiantToolStripMenuItem.Click += new System.EventHandler(this.listerEtudiantToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // Inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 313);
            this.Controls.Add(this.lblProgrammeDispo);
            this.Controls.Add(this.lblEtudiantIns);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inscription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscription";
            this.Load += new System.EventHandler(this.Inscription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEtudiantIns;
        private System.Windows.Forms.Label lblProgrammeDispo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterProgrammeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerProgrammeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listerProgrammeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterEtudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerEtudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listerEtudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    }
}