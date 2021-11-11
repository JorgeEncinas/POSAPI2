using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSAPI2
{
    public partial class Login : Form
    {
        private DBConnection dbconn;
        public static string name = "";
        
        public Login()
        {
            dbconn = new DBConnection();
            InitializeComponent();
            passwdtb.PasswordChar = '*';
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (!usertb.Text.Equals("") & !passwdtb.Text.Equals(""))
            {
                if (Regex.IsMatch(usertb.Text, @"^[a-zA-Z0-9]+$") && Regex.IsMatch(passwdtb.Text, @"^[a-zA-Z0-9]+$"))
                {
                    String passwd = dbconn.GetSHA256(passwdtb.Text);
                    MySqlDataReader result = dbconn.CompareCredentials(usertb.Text, passwd);
                    //dbconn.InsertEncryptedPass(usertb.Text,passwdtb.Text);
                    
                    if (result != null & result.HasRows)
                    {
                        errorlb.Text = "";
                        result.Read();
                        name = result.GetString(0) + " " + result.GetString(1) + " " + result.GetString(2);
                        this.Hide();
                        if (result.GetString(11).Equals("1"))
                        {
                            Reportes poswindow = new Reportes();
                            poswindow.ShowDialog();
                        }
                        else
                        {
                            Form1 poswindow = new Form1();
                            poswindow.ShowDialog();
                        }
                        this.Show();
                        dbconn.CloseConnection();
                    }
                    else
                    {
                        errorlb.Text = "Error de conexion";
                        errorlb.Location = new Point(Convert.ToInt32(this.Width / 2 - errorlb.Width / 2), Convert.ToInt32(this.Height * 0.70));
                        dbconn.CloseConnection();
                    }
                    
                }
                else
                {
                    errorlb.Text = "Los datos introducidos no son validos";
                    errorlb.Location = new Point(Convert.ToInt32(this.Width / 2 - errorlb.Width / 2), Convert.ToInt32(this.Height * 0.70));
                }
            }
            else
            {
                usertb.Focus();
                errorlb.Text = "Uno de los campos está vacío";
                errorlb.Location = new Point(Convert.ToInt32(this.Width / 2 - errorlb.Width / 2), Convert.ToInt32(this.Height * 0.70));
            }
            
        }

        private void setLayout()
        {
            this.Width = 350;
            this.Height = 450;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            iconpb.Width = Convert.ToInt32(this.Width * 0.50);
            iconpb.Height = Convert.ToInt32(this.Height * 0.15);
            iconpb.Location = new Point(Convert.ToInt32(this.Width * 0.50 - iconpb.Width * 0.50), Convert.ToInt32(this.Height * 0.05));
            loginlb.Text = "LOG IN";
            loginlb.Font = new Font("Times new Roman", 20F, FontStyle.Bold);
            loginlb.Location = new Point(Convert.ToInt32(this.Width * 0.50 - loginlb.Width * 0.50), Convert.ToInt32(iconpb.Location.Y + iconpb.Height + this.Height * 0.05));
            userlb.Text = "Usuario:";
            userlb.Font = new Font("Times new Roman", 16F, FontStyle.Bold);
            userlb.Location = new Point(Convert.ToInt32(this.Width * 0.40 - userlb.Width), Convert.ToInt32(this.Height * 0.40));
            usertb.Text = "";
            usertb.Font = new Font("Times new Roman", 14F, FontStyle.Regular);
            usertb.Location = new Point(Convert.ToInt32(userlb.Location.X + userlb.Width), Convert.ToInt32(this.Height * 0.41));
            usertb.BackColor = this.BackColor;
            userpanel.Width = Convert.ToInt32(usertb.Width);
            userpanel.Height = 1;
            userpanel.Location = new Point(usertb.Location.X, userlb.Location.Y + userlb.Height);
            userpanel.BackColor = Color.Black;
            passwdlb.Text = "Contraseña:";
            passwdlb.Font = new Font("Times new Roman", 16F, FontStyle.Bold);
            passwdlb.Location = new Point(Convert.ToInt32(this.Width * 0.40 - passwdlb.Width), Convert.ToInt32(this.Height * 0.55));
            passwdtb.Text = "";
            passwdtb.Font = new Font("Times new Roman", 14F, FontStyle.Regular);
            passwdtb.Location = new Point(Convert.ToInt32(passwdlb.Location.X + passwdlb.Width), Convert.ToInt32(this.Height * 0.55));
            passwdtb.BackColor = this.BackColor;
            passwdpanel.Width = Convert.ToInt32(passwdtb.Width);
            passwdpanel.Height = 1;
            passwdpanel.Location = new Point(passwdtb.Location.X, passwdlb.Location.Y + passwdlb.Height);
            passwdpanel.BackColor = Color.Black;
            errorlb.Text = "";
            errorlb.Font = new Font("Times new Roman", 14F, FontStyle.Regular);
            errorlb.ForeColor = Color.FromArgb(255, 51, 51);
            loginbtn.Width = Convert.ToInt32(this.Width * 0.30);
            loginbtn.Height = 30;
            loginbtn.Font = new Font("Times new Roman", 14F, FontStyle.Bold);
            loginbtn.Location = new Point(Convert.ToInt32(this.Width * 0.50 - loginbtn.Width * 0.50), Convert.ToInt32(this.Height * 0.80));
        }

        private void Login_Load(object sender, EventArgs e)
        {
            setLayout();
        }

        private void usertb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                loginbtn_Click(sender, e);
            }
        }

        private void passwdtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                loginbtn_Click(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
