namespace C_sharp_Projet_Finale
{
    partial class ListerEtudiants
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
            this.lblListTitre = new System.Windows.Forms.Label();
            this.lblListCodeEtud = new System.Windows.Forms.Label();
            this.lblListNomEtud = new System.Windows.Forms.Label();
            this.lblListPrenomEtud = new System.Windows.Forms.Label();
            this.lblListDate = new System.Windows.Forms.Label();
            this.lblListCourriel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnListAnnuler = new System.Windows.Forms.Button();
            this.btnListRetour = new System.Windows.Forms.Button();
            this.btnPremier = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnDernier = new System.Windows.Forms.Button();
            this.txtListCodeEtud = new System.Windows.Forms.TextBox();
            this.txtListNomEtud = new System.Windows.Forms.TextBox();
            this.txtListPrEtud = new System.Windows.Forms.TextBox();
            this.txtListDateEtud = new System.Windows.Forms.TextBox();
            this.txtListCourriel = new System.Windows.Forms.TextBox();
            this.txtListCodeProgEtud = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListTitre
            // 
            this.lblListTitre.AutoSize = true;
            this.lblListTitre.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListTitre.Location = new System.Drawing.Point(220, 26);
            this.lblListTitre.Name = "lblListTitre";
            this.lblListTitre.Size = new System.Drawing.Size(402, 27);
            this.lblListTitre.TabIndex = 0;
            this.lblListTitre.Text = "Liste des etudiants du College";
            // 
            // lblListCodeEtud
            // 
            this.lblListCodeEtud.AutoSize = true;
            this.lblListCodeEtud.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListCodeEtud.Location = new System.Drawing.Point(120, 77);
            this.lblListCodeEtud.Name = "lblListCodeEtud";
            this.lblListCodeEtud.Size = new System.Drawing.Size(190, 22);
            this.lblListCodeEtud.TabIndex = 1;
            this.lblListCodeEtud.Text = "Code de l\'etudiant";
            // 
            // lblListNomEtud
            // 
            this.lblListNomEtud.AutoSize = true;
            this.lblListNomEtud.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListNomEtud.Location = new System.Drawing.Point(123, 118);
            this.lblListNomEtud.Name = "lblListNomEtud";
            this.lblListNomEtud.Size = new System.Drawing.Size(180, 22);
            this.lblListNomEtud.TabIndex = 2;
            this.lblListNomEtud.Text = "Nom de l\'etudiant";
            // 
            // lblListPrenomEtud
            // 
            this.lblListPrenomEtud.AutoSize = true;
            this.lblListPrenomEtud.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListPrenomEtud.Location = new System.Drawing.Point(123, 163);
            this.lblListPrenomEtud.Name = "lblListPrenomEtud";
            this.lblListPrenomEtud.Size = new System.Drawing.Size(189, 20);
            this.lblListPrenomEtud.TabIndex = 3;
            this.lblListPrenomEtud.Text = "Prenom de l\'etudiant";
            // 
            // lblListDate
            // 
            this.lblListDate.AutoSize = true;
            this.lblListDate.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListDate.Location = new System.Drawing.Point(123, 211);
            this.lblListDate.Name = "lblListDate";
            this.lblListDate.Size = new System.Drawing.Size(180, 22);
            this.lblListDate.TabIndex = 4;
            this.lblListDate.Text = "Date de naissance";
            // 
            // lblListCourriel
            // 
            this.lblListCourriel.AutoSize = true;
            this.lblListCourriel.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListCourriel.Location = new System.Drawing.Point(123, 257);
            this.lblListCourriel.Name = "lblListCourriel";
            this.lblListCourriel.Size = new System.Drawing.Size(90, 22);
            this.lblListCourriel.TabIndex = 5;
            this.lblListCourriel.Text = "Courriel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(123, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 44);
            this.label7.TabIndex = 6;
            this.label7.Text = "Code du programme\r\ninscrit";
            // 
            // btnListAnnuler
            // 
            this.btnListAnnuler.Location = new System.Drawing.Point(268, 370);
            this.btnListAnnuler.Name = "btnListAnnuler";
            this.btnListAnnuler.Size = new System.Drawing.Size(116, 30);
            this.btnListAnnuler.TabIndex = 7;
            this.btnListAnnuler.Text = "Annuler";
            this.btnListAnnuler.UseVisualStyleBackColor = true;
            this.btnListAnnuler.Click += new System.EventHandler(this.btnListAnnuler_Click);
            // 
            // btnListRetour
            // 
            this.btnListRetour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnListRetour.Location = new System.Drawing.Point(398, 370);
            this.btnListRetour.Name = "btnListRetour";
            this.btnListRetour.Size = new System.Drawing.Size(116, 30);
            this.btnListRetour.TabIndex = 8;
            this.btnListRetour.Text = "Retour";
            this.btnListRetour.UseVisualStyleBackColor = true;
            this.btnListRetour.Click += new System.EventHandler(this.btnListRetour_Click);
            // 
            // btnPremier
            // 
            this.btnPremier.Location = new System.Drawing.Point(622, 164);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(106, 25);
            this.btnPremier.TabIndex = 9;
            this.btnPremier.Text = "Premier";
            this.btnPremier.UseVisualStyleBackColor = true;
            this.btnPremier.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(622, 193);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(106, 25);
            this.btnPrecedent.TabIndex = 10;
            this.btnPrecedent.Text = "Precedent";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.button4_Click);
            this.btnPrecedent.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnPrecedent_KeyUp);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(622, 222);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(106, 25);
            this.btnSuivant.TabIndex = 11;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnDernier
            // 
            this.btnDernier.Location = new System.Drawing.Point(622, 251);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(106, 25);
            this.btnDernier.TabIndex = 12;
            this.btnDernier.Text = "Dernier";
            this.btnDernier.UseVisualStyleBackColor = true;
            this.btnDernier.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtListCodeEtud
            // 
            this.txtListCodeEtud.Enabled = false;
            this.txtListCodeEtud.Location = new System.Drawing.Point(330, 78);
            this.txtListCodeEtud.Name = "txtListCodeEtud";
            this.txtListCodeEtud.Size = new System.Drawing.Size(180, 22);
            this.txtListCodeEtud.TabIndex = 13;
            // 
            // txtListNomEtud
            // 
            this.txtListNomEtud.Enabled = false;
            this.txtListNomEtud.Location = new System.Drawing.Point(330, 118);
            this.txtListNomEtud.Name = "txtListNomEtud";
            this.txtListNomEtud.Size = new System.Drawing.Size(259, 22);
            this.txtListNomEtud.TabIndex = 14;
            // 
            // txtListPrEtud
            // 
            this.txtListPrEtud.Enabled = false;
            this.txtListPrEtud.Location = new System.Drawing.Point(330, 166);
            this.txtListPrEtud.Name = "txtListPrEtud";
            this.txtListPrEtud.Size = new System.Drawing.Size(259, 22);
            this.txtListPrEtud.TabIndex = 15;
            // 
            // txtListDateEtud
            // 
            this.txtListDateEtud.Enabled = false;
            this.txtListDateEtud.Location = new System.Drawing.Point(330, 211);
            this.txtListDateEtud.Name = "txtListDateEtud";
            this.txtListDateEtud.Size = new System.Drawing.Size(180, 22);
            this.txtListDateEtud.TabIndex = 16;
            // 
            // txtListCourriel
            // 
            this.txtListCourriel.Enabled = false;
            this.txtListCourriel.Location = new System.Drawing.Point(330, 257);
            this.txtListCourriel.Name = "txtListCourriel";
            this.txtListCourriel.Size = new System.Drawing.Size(259, 22);
            this.txtListCourriel.TabIndex = 17;
            // 
            // txtListCodeProgEtud
            // 
            this.txtListCodeProgEtud.Enabled = false;
            this.txtListCodeProgEtud.Location = new System.Drawing.Point(330, 303);
            this.txtListCodeProgEtud.Name = "txtListCodeProgEtud";
            this.txtListCodeProgEtud.Size = new System.Drawing.Size(180, 22);
            this.txtListCodeProgEtud.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::C_sharp_Projet_Finale.Properties.Resources.ListerEtudiantLogo;
            this.pictureBox1.Location = new System.Drawing.Point(637, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // ListerEtudiants
            // 
            this.AcceptButton = this.btnPremier;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnListRetour;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtListCodeProgEtud);
            this.Controls.Add(this.txtListCourriel);
            this.Controls.Add(this.txtListDateEtud);
            this.Controls.Add(this.txtListPrEtud);
            this.Controls.Add(this.txtListNomEtud);
            this.Controls.Add(this.txtListCodeEtud);
            this.Controls.Add(this.btnDernier);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.btnPrecedent);
            this.Controls.Add(this.btnPremier);
            this.Controls.Add(this.btnListRetour);
            this.Controls.Add(this.btnListAnnuler);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblListCourriel);
            this.Controls.Add(this.lblListDate);
            this.Controls.Add(this.lblListPrenomEtud);
            this.Controls.Add(this.lblListNomEtud);
            this.Controls.Add(this.lblListCodeEtud);
            this.Controls.Add(this.lblListTitre);
            this.Name = "ListerEtudiants";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscriptions College - Lister etudiants";
            this.Load += new System.EventHandler(this.ListerEtudiants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListTitre;
        private System.Windows.Forms.Label lblListCodeEtud;
        private System.Windows.Forms.Label lblListNomEtud;
        private System.Windows.Forms.Label lblListPrenomEtud;
        private System.Windows.Forms.Label lblListDate;
        private System.Windows.Forms.Label lblListCourriel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnListAnnuler;
        private System.Windows.Forms.Button btnListRetour;
        private System.Windows.Forms.Button btnPremier;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnDernier;
        private System.Windows.Forms.TextBox txtListCodeEtud;
        private System.Windows.Forms.TextBox txtListNomEtud;
        private System.Windows.Forms.TextBox txtListPrEtud;
        private System.Windows.Forms.TextBox txtListDateEtud;
        private System.Windows.Forms.TextBox txtListCourriel;
        private System.Windows.Forms.TextBox txtListCodeProgEtud;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}