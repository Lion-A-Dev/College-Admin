namespace C_sharp_Projet_Finale
{
    partial class AjoutEtudiant
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
            this.txtTitre = new System.Windows.Forms.Label();
            this.lblCodeEtudiant = new System.Windows.Forms.Label();
            this.lblNomEtud = new System.Windows.Forms.Label();
            this.lblPrenomEtud = new System.Windows.Forms.Label();
            this.lblDateNaiss = new System.Windows.Forms.Label();
            this.lblCourriel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodeEtud = new System.Windows.Forms.TextBox();
            this.txtNomEtud = new System.Windows.Forms.TextBox();
            this.txtPreEtud = new System.Windows.Forms.TextBox();
            this.txtCourriel = new System.Windows.Forms.TextBox();
            this.btnAjouEtudAnnuler = new System.Windows.Forms.Button();
            this.btnAjoutEtudAjouter = new System.Windows.Forms.Button();
            this.btnAjoutEtudRetour = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpNaissance = new System.Windows.Forms.DateTimePicker();
            this.cbEtudProgCode = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitre
            // 
            this.txtTitre.AutoSize = true;
            this.txtTitre.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitre.Location = new System.Drawing.Point(253, 13);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(259, 27);
            this.txtTitre.TabIndex = 0;
            this.txtTitre.Text = "Ajout d\'un etudiant";
            // 
            // lblCodeEtudiant
            // 
            this.lblCodeEtudiant.AutoSize = true;
            this.lblCodeEtudiant.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeEtudiant.Location = new System.Drawing.Point(92, 65);
            this.lblCodeEtudiant.Name = "lblCodeEtudiant";
            this.lblCodeEtudiant.Size = new System.Drawing.Size(190, 22);
            this.lblCodeEtudiant.TabIndex = 1;
            this.lblCodeEtudiant.Text = "Code de l\'etudiant";
            // 
            // lblNomEtud
            // 
            this.lblNomEtud.AutoSize = true;
            this.lblNomEtud.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomEtud.Location = new System.Drawing.Point(93, 112);
            this.lblNomEtud.Name = "lblNomEtud";
            this.lblNomEtud.Size = new System.Drawing.Size(180, 22);
            this.lblNomEtud.TabIndex = 2;
            this.lblNomEtud.Text = "Nom de l\'etudiant";
            // 
            // lblPrenomEtud
            // 
            this.lblPrenomEtud.AutoSize = true;
            this.lblPrenomEtud.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenomEtud.Location = new System.Drawing.Point(93, 163);
            this.lblPrenomEtud.Name = "lblPrenomEtud";
            this.lblPrenomEtud.Size = new System.Drawing.Size(210, 22);
            this.lblPrenomEtud.TabIndex = 3;
            this.lblPrenomEtud.Text = "Prenom de l\'etudiant";
            // 
            // lblDateNaiss
            // 
            this.lblDateNaiss.AutoSize = true;
            this.lblDateNaiss.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateNaiss.Location = new System.Drawing.Point(93, 217);
            this.lblDateNaiss.Name = "lblDateNaiss";
            this.lblDateNaiss.Size = new System.Drawing.Size(180, 22);
            this.lblDateNaiss.TabIndex = 4;
            this.lblDateNaiss.Text = "Date de naissance";
            // 
            // lblCourriel
            // 
            this.lblCourriel.AutoSize = true;
            this.lblCourriel.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourriel.Location = new System.Drawing.Point(93, 269);
            this.lblCourriel.Name = "lblCourriel";
            this.lblCourriel.Size = new System.Drawing.Size(90, 22);
            this.lblCourriel.TabIndex = 5;
            this.lblCourriel.Text = "Courriel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(93, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Code de Programme inscrit";
            // 
            // txtCodeEtud
            // 
            this.txtCodeEtud.Enabled = false;
            this.txtCodeEtud.Location = new System.Drawing.Point(383, 65);
            this.txtCodeEtud.Name = "txtCodeEtud";
            this.txtCodeEtud.Size = new System.Drawing.Size(203, 22);
            this.txtCodeEtud.TabIndex = 7;
            this.txtCodeEtud.TextChanged += new System.EventHandler(this.txtCodeEtud_TextChanged);
            // 
            // txtNomEtud
            // 
            this.txtNomEtud.Location = new System.Drawing.Point(383, 112);
            this.txtNomEtud.Name = "txtNomEtud";
            this.txtNomEtud.Size = new System.Drawing.Size(203, 22);
            this.txtNomEtud.TabIndex = 8;
            // 
            // txtPreEtud
            // 
            this.txtPreEtud.Location = new System.Drawing.Point(383, 163);
            this.txtPreEtud.Name = "txtPreEtud";
            this.txtPreEtud.Size = new System.Drawing.Size(203, 22);
            this.txtPreEtud.TabIndex = 9;
            // 
            // txtCourriel
            // 
            this.txtCourriel.Location = new System.Drawing.Point(383, 269);
            this.txtCourriel.Name = "txtCourriel";
            this.txtCourriel.Size = new System.Drawing.Size(203, 22);
            this.txtCourriel.TabIndex = 11;
            // 
            // btnAjouEtudAnnuler
            // 
            this.btnAjouEtudAnnuler.Location = new System.Drawing.Point(248, 380);
            this.btnAjouEtudAnnuler.Name = "btnAjouEtudAnnuler";
            this.btnAjouEtudAnnuler.Size = new System.Drawing.Size(91, 32);
            this.btnAjouEtudAnnuler.TabIndex = 13;
            this.btnAjouEtudAnnuler.Text = "Annuler";
            this.btnAjouEtudAnnuler.UseVisualStyleBackColor = true;
            this.btnAjouEtudAnnuler.Click += new System.EventHandler(this.btnAjouEtudAnnuler_Click);
            // 
            // btnAjoutEtudAjouter
            // 
            this.btnAjoutEtudAjouter.Location = new System.Drawing.Point(368, 380);
            this.btnAjoutEtudAjouter.Name = "btnAjoutEtudAjouter";
            this.btnAjoutEtudAjouter.Size = new System.Drawing.Size(82, 32);
            this.btnAjoutEtudAjouter.TabIndex = 14;
            this.btnAjoutEtudAjouter.Text = "Ajouter";
            this.btnAjoutEtudAjouter.UseVisualStyleBackColor = true;
            this.btnAjoutEtudAjouter.Click += new System.EventHandler(this.btnAjoutEtudAjouter_Click);
            // 
            // btnAjoutEtudRetour
            // 
            this.btnAjoutEtudRetour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAjoutEtudRetour.Location = new System.Drawing.Point(473, 380);
            this.btnAjoutEtudRetour.Name = "btnAjoutEtudRetour";
            this.btnAjoutEtudRetour.Size = new System.Drawing.Size(85, 32);
            this.btnAjoutEtudRetour.TabIndex = 15;
            this.btnAjoutEtudRetour.Text = "Retour";
            this.btnAjoutEtudRetour.UseVisualStyleBackColor = true;
            this.btnAjoutEtudRetour.Click += new System.EventHandler(this.btnAjoutEtudRetour_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::C_sharp_Projet_Finale.Properties.Resources.addStudentLogo;
            this.pictureBox1.Location = new System.Drawing.Point(607, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // dtpNaissance
            // 
            this.dtpNaissance.Location = new System.Drawing.Point(383, 217);
            this.dtpNaissance.Name = "dtpNaissance";
            this.dtpNaissance.Size = new System.Drawing.Size(203, 22);
            this.dtpNaissance.TabIndex = 17;
            this.dtpNaissance.Value = new System.DateTime(2024, 6, 1, 9, 48, 36, 0);
            this.dtpNaissance.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cbEtudProgCode
            // 
            this.cbEtudProgCode.FormattingEnabled = true;
            this.cbEtudProgCode.Location = new System.Drawing.Point(383, 324);
            this.cbEtudProgCode.Name = "cbEtudProgCode";
            this.cbEtudProgCode.Size = new System.Drawing.Size(203, 24);
            this.cbEtudProgCode.TabIndex = 18;
            this.cbEtudProgCode.SelectedIndexChanged += new System.EventHandler(this.cbEtudProgCode_SelectedIndexChanged);
            // 
            // AjoutEtudiant
            // 
            this.AcceptButton = this.btnAjoutEtudAjouter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAjoutEtudRetour;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbEtudProgCode);
            this.Controls.Add(this.dtpNaissance);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAjoutEtudRetour);
            this.Controls.Add(this.btnAjoutEtudAjouter);
            this.Controls.Add(this.btnAjouEtudAnnuler);
            this.Controls.Add(this.txtCourriel);
            this.Controls.Add(this.txtPreEtud);
            this.Controls.Add(this.txtNomEtud);
            this.Controls.Add(this.txtCodeEtud);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCourriel);
            this.Controls.Add(this.lblDateNaiss);
            this.Controls.Add(this.lblPrenomEtud);
            this.Controls.Add(this.lblNomEtud);
            this.Controls.Add(this.lblCodeEtudiant);
            this.Controls.Add(this.txtTitre);
            this.Name = "AjoutEtudiant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscription College - Ajouter etudiant";
            this.Load += new System.EventHandler(this.AjoutEtudiant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTitre;
        private System.Windows.Forms.Label lblCodeEtudiant;
        private System.Windows.Forms.Label lblNomEtud;
        private System.Windows.Forms.Label lblPrenomEtud;
        private System.Windows.Forms.Label lblDateNaiss;
        private System.Windows.Forms.Label lblCourriel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodeEtud;
        private System.Windows.Forms.TextBox txtNomEtud;
        private System.Windows.Forms.TextBox txtPreEtud;
        private System.Windows.Forms.TextBox txtCourriel;
        private System.Windows.Forms.Button btnAjouEtudAnnuler;
        private System.Windows.Forms.Button btnAjoutEtudAjouter;
        private System.Windows.Forms.Button btnAjoutEtudRetour;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpNaissance;
        private System.Windows.Forms.ComboBox cbEtudProgCode;
    }
}