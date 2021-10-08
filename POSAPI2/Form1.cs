using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace POSAPI2
{
    public partial class Form1 : Form
    {
        private double total = 0;
        private double change = 0;
        public Form1()
        {
            InitializeComponent();
            dgv1.Columns.Add("cantidad", "Cantidad");
            dgv1.Columns.Add("nombre","Nombre");
            dgv1.Columns.Add("precio", "Precio");
            dgv1.Columns.Add("total", "Total");
            textBox1.Focus();
        }

        private void Form1_Load()
        {
            labelTotal.Location = new Point(Convert.ToInt32(dgv1.Width - labelTotal.Width), Convert.ToInt32(dgv1.Height + labelTotal.Height + 20));
            labelTotal.Text = "";
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                String query = "SELECT * FROM productos WHERE producto_codigo =" + textBox1.Text;

                try
                {
                    MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=verificador_de_precios; SSL mode=none");
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                    MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                    if (mySqlDataReader.HasRows)
                    {
                        mySqlDataReader.Read();
                        dgv1.Rows.Add("1", mySqlDataReader.GetString(1), String.Format("{0:0.00}", mySqlDataReader.GetDouble(3)), String.Format("{0:0.00}", mySqlDataReader.GetDouble(3)));
                        labelTotal.Text = GetTotal().ToString();

                    }
                    else
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private double GetTotal()
        {
            total = 0;
            foreach (DataGridViewRow row in dgv1.Rows)
            {
                total += Double.Parse(row.Cells[3].Value.ToString());
            }
            return total;
        }

        private double GetChange(double payment)
        {
            change = 0;
            if (labelTotal.Text != "")
            {
                change = Double.Parse(labelTotal.Text) - payment;
            }
            return change;
        }
    }
}
