using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSAPI2
{
    public partial class Form1 : Form
    {
        private double total = 0;
        public Form1()
        {
            InitializeComponent();
            dgv1.Columns.Add("cantidad", "Cantidad");
            dgv1.Columns.Add("nombre","Nombre");
            dgv1.Columns.Add("precio", "Precio");
            dgv1.Columns.Add("total", "Total");

            
        }

        private void Form1_Load()
        {
            labelTotal.Location = new Point(Convert.ToInt32(dgv1.Width - labelTotal.Width), Convert.ToInt32(dgv1.Height + labelTotal.Height + 20));
        }

        private void dgv1_keyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                labelTotal.Text = GetTotal().ToString();
            }
        }
        private double GetTotal()
        {
            total = 0;
            foreach (int row in dgv1.Rows)
            {
                total += Double.Parse(dgv1[3,row].Value.ToString());
            }
            return total;
        }
    }
}
