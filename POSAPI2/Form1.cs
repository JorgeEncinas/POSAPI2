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
        public Form1()
        {
            InitializeComponent();
            dgv1.Columns.Add("cantidad", "Cantidad");
            dgv1.Columns.Add("nombre","Nombre");
            dgv1.Columns.Add("precio", "Precio");
            dgv1.Columns.Add("total", "Total");
        }
    }
}
