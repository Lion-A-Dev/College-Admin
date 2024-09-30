namespace C_sharp_Projet_Finale
{
    partial class AjoutProgramme
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
            this.txtCodeProg = new System.Windows.Forms.TextBox();
            this.txtDomainProg = new System.Windows.Forms.TextBox();
            this.txtNomProg = new System.Windows.Forms.TextBox();
            this.txtHeureProg = new System.Windows.Forms.TextBox();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_retour = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code du Programme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Domaine";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom du Programme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(158, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre d\'heures";
            // 
            // txtCodeProg
            // 
            this.txtCodeProg.Location = new System.Drawing.Point(362, 101);
            this.txtCodeProg.Name = "txtCodeProg";
            this.txtCodeProg.Size = new System.Drawing.Size(114, 22);
            this.txtCodeProg.TabIndex = 4;
            // 
            // txtDomainProg
            // 
            this.txtDomainProg.Location = new System.Drawing.Point(362, 154);
            this.txtDomainProg.Name = "txtDomainProg";
            this.txtDomainProg.Size = new System.Drawing.Size(233, 22);
            this.txtDomainProg.TabIndex = 5;
            // 
            // txtNomProg
            // 
            this.txtNomProg.Location = new System.Drawing.Point(362, 209);
            this.txtNomProg.Name = "txtNomProg";
            this.txtNomProg.Size = new System.Drawing.Size(233, 22);
            this.txtNomProg.TabIndex = 6;
            // 
            // txtHeureProg
            // 
            this.txtHeureProg.Location = new System.Drawing.Point(362, 263);
            this.txtHeureProg.Name = "txtHeureProg";
            this.txtHeureProg.Size = new System.Drawing.Size(114, 22);
            this.txtHeureProg.TabIndex = 7;
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(208, 337);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(110, 39);
            this.btn_annuler.TabIndex = 8;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(344, 337);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(96, 39);
            this.btn_ajouter.TabIndex = 9;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_retour
            // 
            this.btn_retour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_retour.Location = new System.Drawing.Point(464, 337);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(94, 39);
            this.btn_retour.TabIndex = 10;
            this.btn_retour.Text = "Retour";
            this.btn_retour.UseVisualStyleBackColor = true;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::C_sharp_Projet_Finale.Properties.Resources.add_folder;
            this.pictureBox1.Location = new System.Drawing.Point(623, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // AjoutProgramme
            // 
            this.AcceptButton = this.btn_ajouter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_retour;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_retour);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.txtHeureProg);
            this.Controls.Add(this.txtNomProg);
            this.Controls.Add(this.txtDomainProg);
            this.Controls.Add(this.txtCodeProg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AjoutProgramme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscriptions College - Ajouter programme";
            this.Load += new System.EventHandler(this.AjoutProgramme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodeProg;
        private System.Windows.Forms.TextBox txtDomainProg;
        private System.Windows.Forms.TextBox txtNomProg;
        private System.Windows.Forms.TextBox txtHeureProg;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_retour;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}