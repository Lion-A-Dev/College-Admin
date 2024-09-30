namespace C_sharp_Projet_Finale
{
    partial class Login
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btn_conn = new System.Windows.Forms.Button();
            this.btn_quit_auth = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(455, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Authentification";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom d\'utilisateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mot de passe";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(512, 137);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(194, 22);
            this.txtUser.TabIndex = 4;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(512, 200);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(194, 22);
            this.txtPass.TabIndex = 5;
            // 
            // btn_conn
            // 
            this.btn_conn.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conn.Location = new System.Drawing.Point(387, 277);
            this.btn_conn.Name = "btn_conn";
            this.btn_conn.Size = new System.Drawing.Size(122, 33);
            this.btn_conn.TabIndex = 6;
            this.btn_conn.Text = "Connexion";
            this.btn_conn.UseVisualStyleBackColor = true;
            this.btn_conn.Click += new System.EventHandler(this.btn_conn_Click);
            this.btn_conn.Enter += new System.EventHandler(this.btn_conn_Click);
            // 
            // btn_quit_auth
            // 
            this.btn_quit_auth.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_quit_auth.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quit_auth.Location = new System.Drawing.Point(517, 277);
            this.btn_quit_auth.Name = "btn_quit_auth";
            this.btn_quit_auth.Size = new System.Drawing.Size(124, 29);
            this.btn_quit_auth.TabIndex = 7;
            this.btn_quit_auth.Text = "Quitter";
            this.btn_quit_auth.UseVisualStyleBackColor = true;
            this.btn_quit_auth.Click += new System.EventHandler(this.btn_quit_auth_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::C_sharp_Projet_Finale.Properties.Resources.Capture;
            this.pictureBox1.Location = new System.Drawing.Point(106, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.btn_conn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_quit_auth;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_quit_auth);
            this.Controls.Add(this.btn_conn);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentification";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btn_conn;
        private System.Windows.Forms.Button btn_quit_auth;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

