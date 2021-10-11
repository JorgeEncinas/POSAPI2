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
                        textBox1.Clear();
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
            if (e.KeyChar == 'p' || e.KeyChar == 'P')
            {
                try
                {
                    e.Handled = true;
                    //MessageBox.Show($"¿Va a pagar? {textBox1.Text} {total} {Environment.NewLine} " +
                    //    $"{Convert.ToDouble(textBox1.Text) - total}");
                    labelTotal.Text = $"Cambio: " + GetChange(Double.Parse(textBox1.Text));

                    textBox1.Clear();
                    textBox1.Focus();
                }
                catch (Exception ex)
                {

                }
            }
        }

        private double GetTotal()
        {
            total = 0;
            foreach (DataGridViewRow row in dgv1.Rows)
            {

                total += (Double.Parse(row.Cells[2].Value.ToString())) * (Double.Parse(row.Cells[0].Value.ToString()));
            }
            return total;
        }

        private double GetChange(double payment)
        {
            change = 0;
            if (!labelTotal.Text.Equals(""))
            {
                change = payment - Double.Parse(labelTotal.Text);
            }
            return change;
        }

        private void setLayout()
        {
            /// <summary>Sets the components' size and layout </summary>
            dgv1.Width = Convert.ToInt32(this.Width * 0.95);
            dgv1.Height = Convert.ToInt32(this.Height * 0.825);
            dgv1.Location = new Point(
                Convert.ToInt32(this.Width * 0.025),
                Convert.ToInt32(this.Height * 0.15));
            dgv1.Columns["cantidad"].Width = Convert.ToInt32(dgv1.Width * 0.20);
            dgv1.Columns["nombre"].Width = Convert.ToInt32(dgv1.Width * 0.40);
            dgv1.Columns["precio"].Width = Convert.ToInt32(dgv1.Width * 0.20);
            dgv1.Columns["total"].Width = Convert.ToInt32(dgv1.Width * 0.20);
            pbLogo.Width = Convert.ToInt32(this.Width * 0.20);
            pbLogo.Height = Convert.ToInt32(this.Height * 0.08);
            pbLogo.Location = new Point(
                Convert.ToInt32(this.Width - this.Width*0.05 - pbLogo.Width),
                Convert.ToInt32(this.Height * 0.05));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setLayout();
        }
    }
}
