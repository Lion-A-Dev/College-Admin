namespace C_sharp_Projet_Finale
{
    partial class SupprimerProgramme
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSupCode = new System.Windows.Forms.TextBox();
            this.txtSupDom = new System.Windows.Forms.TextBox();
            this.txtSupNom = new System.Windows.Forms.TextBox();
            this.txtSupHeures = new System.Windows.Forms.TextBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnSupAnnuler = new System.Windows.Forms.Button();
            this.btnSupRetour = new System.Windows.Forms.Button();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code du Programme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Domaine";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom du Programme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombres d\'heures";
            // 
            // txtSupCode
            // 
            this.txtSupCode.Location = new System.Drawing.Point(346, 112);
            this.txtSupCode.Name = "txtSupCode";
            this.txtSupCode.Size = new System.Drawing.Size(136, 22);
            this.txtSupCode.TabIndex = 4;
            // 
            // txtSupDom
            // 
            this.txtSupDom.Enabled = false;
            this.txtSupDom.Location = new System.Drawing.Point(346, 162);
            this.txtSupDom.Name = "txtSupDom";
            this.txtSupDom.Size = new System.Drawing.Size(182, 22);
            this.txtSupDom.TabIndex = 5;
            // 
            // txtSupNom
            // 
            this.txtSupNom.Enabled = false;
            this.txtSupNom.Location = new System.Drawing.Point(346, 209);
            this.txtSupNom.Name = "txtSupNom";
            this.txtSupNom.Size = new System.Drawing.Size(182, 22);
            this.txtSupNom.TabIndex = 6;
            // 
            // txtSupHeures
            // 
            this.txtSupHeures.Enabled = false;
            this.txtSupHeures.Location = new System.Drawing.Point(346, 262);
            this.txtSupHeures.Name = "txtSupHeures";
            this.txtSupHeures.Size = new System.Drawing.Size(87, 22);
            this.txtSupHeures.TabIndex = 7;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(234, 329);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(96, 33);
            this.btnSupprimer.TabIndex = 8;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnSupAnnuler
            // 
            this.btnSupAnnuler.Location = new System.Drawing.Point(346, 329);
            this.btnSupAnnuler.Name = "btnSupAnnuler";
            this.btnSupAnnuler.Size = new System.Drawing.Size(87, 33);
            this.btnSupAnnuler.TabIndex = 9;
            this.btnSupAnnuler.Text = "Annuler";
            this.btnSupAnnuler.UseVisualStyleBackColor = true;
            this.btnSupAnnuler.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSupRetour
            // 
            this.btnSupRetour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSupRetour.Location = new System.Drawing.Point(453, 329);
            this.btnSupRetour.Name = "btnSupRetour";
            this.btnSupRetour.Size = new System.Drawing.Size(91, 33);
            this.btnSupRetour.TabIndex = 10;
            this.btnSupRetour.Text = "Retour";
            this.btnSupRetour.UseVisualStyleBackColor = true;
            this.btnSupRetour.Click += new System.EventHandler(this.btnSupRetour_Click);
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(505, 108);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(108, 31);
            this.btnRecherche.TabIndex = 11;
            this.btnRecherche.Text = "Rechercher";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(194, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(350, 27);
            this.label5.TabIndex = 12;
            this.label5.Text = "Suppression d\'un programme";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::C_sharp_Projet_Finale.Properties.Resources.remove_folder;
            this.pictureBox1.Location = new System.Drawing.Point(632, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // SupprimerProgramme
            // 
            this.AcceptButton = this.btnSupprimer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSupRetour;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRecherche);
            this.Controls.Add(this.btnSupRetour);
            this.Controls.Add(this.btnSupAnnuler);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.txtSupHeures);
            this.Controls.Add(this.txtSupNom);
            this.Controls.Add(this.txtSupDom);
            this.Controls.Add(this.txtSupCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SupprimerProgramme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscription College - Supprimer programme";
            this.Load += new System.EventHandler(this.SupprimerProgramme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSupCode;
        private System.Windows.Forms.TextBox txtSupDom;
        private System.Windows.Forms.TextBox txtSupNom;
        private System.Windows.Forms.TextBox txtSupHeures;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnSupAnnuler;
        private System.Windows.Forms.Button btnSupRetour;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}