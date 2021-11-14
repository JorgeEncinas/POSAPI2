namespace POSAPI2
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
            this.usertb = new System.Windows.Forms.TextBox();
            this.passwdtb = new System.Windows.Forms.TextBox();
            this.userlb = new System.Windows.Forms.Label();
            this.passwdlb = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.errorlb = new System.Windows.Forms.Label();
            this.iconpb = new System.Windows.Forms.PictureBox();
            this.loginlb = new System.Windows.Forms.Label();
            this.userpanel = new System.Windows.Forms.Panel();
            this.passwdpanel = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iconpb)).BeginInit();
            this.SuspendLayout();
            // 
            // usertb
            // 
            this.usertb.BackColor = System.Drawing.SystemColors.Window;
            this.usertb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usertb.Location = new System.Drawing.Point(137, 207);
            this.usertb.Name = "usertb";
            this.usertb.Size = new System.Drawing.Size(145, 13);
            this.usertb.TabIndex = 0;
            this.usertb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usertb_KeyPress);
            // 
            // passwdtb
            // 
            this.passwdtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwdtb.Location = new System.Drawing.Point(137, 284);
            this.passwdtb.Name = "passwdtb";
            this.passwdtb.Size = new System.Drawing.Size(145, 13);
            this.passwdtb.TabIndex = 1;
            this.passwdtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwdtb_KeyPress);
            // 
            // userlb
            // 
            this.userlb.AutoSize = true;
            this.userlb.Location = new System.Drawing.Point(58, 207);
            this.userlb.Name = "userlb";
            this.userlb.Size = new System.Drawing.Size(43, 13);
            this.userlb.TabIndex = 2;
            this.userlb.Text = "Usuario";
            this.userlb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // passwdlb
            // 
            this.passwdlb.AutoSize = true;
            this.passwdlb.Location = new System.Drawing.Point(40, 284);
            this.passwdlb.Name = "passwdlb";
            this.passwdlb.Size = new System.Drawing.Size(61, 13);
            this.passwdlb.TabIndex = 3;
            this.passwdlb.Text = "Contraseña";
            this.passwdlb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbtn.Location = new System.Drawing.Point(97, 362);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(145, 35);
            this.loginbtn.TabIndex = 4;
            this.loginbtn.Text = "ENTRAR";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // errorlb
            // 
            this.errorlb.AutoSize = true;
            this.errorlb.Location = new System.Drawing.Point(144, 331);
            this.errorlb.Name = "errorlb";
            this.errorlb.Size = new System.Drawing.Size(35, 13);
            this.errorlb.TabIndex = 5;
            this.errorlb.Text = "label3";
            // 
            // iconpb
            // 
            this.iconpb.Image = global::POSAPI2.Properties.Resources.placeholder_logo2;
            this.iconpb.Location = new System.Drawing.Point(113, 27);
            this.iconpb.Name = "iconpb";
            this.iconpb.Size = new System.Drawing.Size(100, 50);
            this.iconpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconpb.TabIndex = 6;
            this.iconpb.TabStop = false;
            // 
            // loginlb
            // 
            this.loginlb.AutoSize = true;
            this.loginlb.Location = new System.Drawing.Point(147, 110);
            this.loginlb.Name = "loginlb";
            this.loginlb.Size = new System.Drawing.Size(43, 13);
            this.loginlb.TabIndex = 7;
            this.loginlb.Text = "LOG IN";
            // 
            // userpanel
            // 
            this.userpanel.Location = new System.Drawing.Point(61, 223);
            this.userpanel.Name = "userpanel";
            this.userpanel.Size = new System.Drawing.Size(221, 22);
            this.userpanel.TabIndex = 8;
            // 
            // passwdpanel
            // 
            this.passwdpanel.Location = new System.Drawing.Point(61, 322);
            this.passwdpanel.Name = "passwdpanel";
            this.passwdpanel.Size = new System.Drawing.Size(221, 22);
            this.passwdpanel.TabIndex = 9;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(118, 403);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 35);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.passwdpanel);
            this.Controls.Add(this.userpanel);
            this.Controls.Add(this.loginlb);
            this.Controls.Add(this.iconpb);
            this.Controls.Add(this.errorlb);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.passwdlb);
            this.Controls.Add(this.userlb);
            this.Controls.Add(this.passwdtb);
            this.Controls.Add(this.usertb);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconpb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usertb;
        private System.Windows.Forms.TextBox passwdtb;
        private System.Windows.Forms.Label userlb;
        private System.Windows.Forms.Label passwdlb;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label errorlb;
        private System.Windows.Forms.PictureBox iconpb;
        private System.Windows.Forms.Label loginlb;
        private System.Windows.Forms.Panel userpanel;
        private System.Windows.Forms.Panel passwdpanel;
        private System.Windows.Forms.Button btnSalir;
    }
}