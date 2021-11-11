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
        private DBConnection dbconn;
        private string productKey;

        public Form1()
        {
            InitializeComponent();
            dbconn = new DBConnection();
            productKey = "";
            dgv1.Columns.Add("id", "id");
            dgv1.Columns.Add("cantidad", "Cantidad");
            dgv1.Columns.Add("nombre", "Nombre");
            dgv1.Columns.Add("precio", "Precio");
            dgv1.Columns.Add("total", "Total");
            dgv1.Columns["id"].DisplayIndex = 0;
            dgv1.Columns["cantidad"].DisplayIndex = 1;
            dgv1.Columns["nombre"].DisplayIndex = 2;
            dgv1.Columns["precio"].DisplayIndex = 3;
            dgv1.Columns["total"].DisplayIndex = 4;
        }

        private void GetTotal()
        {
            total = 0;
            foreach (DataGridViewRow row in dgv1.Rows)
            {

                total += (Double.Parse(row.Cells[3].Value.ToString())) * (Double.Parse(row.Cells[1].Value.ToString()));
            }
            lbTotalName.Text = "Total:";
            labelTotal.Text = total.ToString();
            
      }

        private double GetChange(double payment)
        {
            change = 0;
            if (!labelTotal.Text.Equals(""))
            {
                change = payment - Double.Parse(labelTotal.Text);
            }
            lbTotalName.Text = "Cambio:";
            labelTotal.Text = change.ToString();
            return change;
        }

        private void centerElementAtY(Control parent, Control child, double parentPercentage, double childPercentage)
        {
            child.Location = new Point(Convert.ToInt32(parent.Width / 2 - child.Width / 2),
                    Convert.ToInt32((parent.Height * parentPercentage) - (child.Height * childPercentage)));
        }

        private void setLayout()
        {
            /// <summary>Sets the components' size and layout </summary>
            dgv1.Columns["id"].Visible = false;
            dgv1.Width = Convert.ToInt32(this.Width * 0.65);
            dgv1.Height = Convert.ToInt32(this.Height * 0.90);
            dgv1.Location = new Point(
                Convert.ToInt32(this.Width * 0.025),
                Convert.ToInt32(this.Height * 0.08));
            dgv1.Columns["cantidad"].Width = Convert.ToInt32(dgv1.Width * 0.20);
            dgv1.Columns["nombre"].Width = Convert.ToInt32(dgv1.Width * 0.40);
            dgv1.Columns["precio"].Width = Convert.ToInt32(dgv1.Width * 0.20);
            dgv1.Columns["total"].Width = Convert.ToInt32(dgv1.Width * 0.20);
            dgv1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv1.ColumnHeadersDefaultCellStyle.Font = new Font("Times new Roman", 20F, FontStyle.Bold);
            pbLogo.Width = Convert.ToInt32(this.Width * 0.20);
            pbLogo.Height = Convert.ToInt32(this.Height * 0.08);
            pbLogo.Location = new Point(
                Convert.ToInt32(this.Width - this.Width * 0.05 - pbLogo.Width),
                Convert.ToInt32(this.Height * 0.05));
            lbTotalName.Location = new Point(Convert.ToInt32(this.Width * 0.69), Convert.ToInt32(this.Height*0.17));
            labelTotal.Location = new Point(Convert.ToInt32(this.Width * 0.89), Convert.ToInt32(this.Height*0.17));
            labelTotal.Text = "";
            textBox1.Location = new Point(Convert.ToInt32(this.Width * 0.05), Convert.ToInt32(this.Height*0.08));
            panelPay.Width = Convert.ToInt32(this.Width * 0.4);
            panelPay.Height = Convert.ToInt32(this.Height * 0.4);
            centerElementAtY(this, panelPay, 0.50, 0.50);

            namelb.Text = Login.name;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setLayout();
        }

        private void showPanel(string msg)
        {
            //Step 1.- Change msg
            lbMsg.Text = msg;
            //Step 2.- Re-center msg
            centerElementAtY(panelPay, lbMsg, 0.30, 0.50);
            //Step 3.- Set which buttons to show according to parameters
            //Step 4.- Return a boolean value or set an action for the buttons
            //Step 5.- Set panel Visible
        }

        private void dgv1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 13)
            {
                if (!productKey.Equals(""))
                {
                    String query = "SELECT * FROM productos WHERE producto_codigo =" + productKey;
                    try
                    {
                        MySqlDataReader result = dbconn.queryProduct(query);
                        if (result != null & result.HasRows) //Shortcircuit AND logical operator stops at first result if FALSE
                        {
                            result.Read();
                            Boolean encontrado = false;
                            for (int i = dgv1.Rows.Count - 1; i > -1; i--)
                            {
                                if (dgv1.Rows[i].Cells[0].Value.ToString().Equals(result.GetString(0))) //Compare name
                                {
                                    int x = Int32.Parse(dgv1.Rows[i].Cells["cantidad"].Value.ToString());
                                    double nuevoTotal = Double.Parse(dgv1.Rows[i].Cells["precio"].Value.ToString());
                                    nuevoTotal = (x + 1) * nuevoTotal;
                                    dgv1.Rows[i].Cells["cantidad"].Value = x + 1;
                                    dgv1.Rows[i].Cells["total"].Value = nuevoTotal;
                                    encontrado = true;
                                    dgv1.Rows[i].Selected = true;
                                    i = 0;
                                }
                            }
                            if (encontrado == false)
                            {
                                dgv1.Rows.Add(result.GetInt32(0),
                                          "1",
                                          result.GetString(1),
                                          String.Format("{0:0.00}", result.GetDouble(3)),
                                          String.Format("{0:0.00}", result.GetDouble(3)));
                                dgv1.Rows[dgv1.Rows.Count - 1].Selected = true;
                            }
                            GetTotal();
                        }
                        result.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                
                productKey = "";
            }
            
            else if (e.KeyChar == 'p' || e.KeyChar == 'P')
            {
                if (dgv1.Rows.Count > 0)
                {
                    try
                    {
                        e.Handled = true;
                        //MessageBox.Show($"¿Completar la transacción? {textBox1.Text} {total} {Environment.NewLine} ");
                        MessageBox.Show($"¿Completar la transacción? {productKey} {total} {Environment.NewLine} ",
                                        "Título",
                                        MessageBoxButtons.OKCancel);
                        GetChange(Double.Parse(productKey)).ToString();
                        productKey = "";
                        dgv1.Rows.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ha ocurrido un error al realizar el pago y se ha abortado la operación.");
                    }
                }
                
            }

            else if (e.KeyChar == 8)
            {
                if (dgv1.Rows.Count > 0)
                {
                    //showPanel("¿Seguro que desea eliminar este producto?");
                    DataGridViewRow item = dgv1.SelectedRows[0];
                    MessageBox.Show($"Se eliminará el producto {item.Cells[2].Value.ToString()}");
                    int itemQuantity = Convert.ToInt32(item.Cells[1].Value);
                    if (itemQuantity > 1)
                    {
                        item.Cells[1].Value = itemQuantity - 1;
                    }
                    else
                    {
                        int nuevoIndice;
                        if (item.Index == 0)
                        {
                            nuevoIndice = item.Index;
                        }
                        else
                        {
                            nuevoIndice = item.Index - 1;
                        }
                        dgv1.Rows[nuevoIndice].Selected = true;
                        dgv1.Rows.RemoveAt(item.Index);
                    }
                    GetTotal();
                    productKey = "";
                }
                
            }
            else
            {
                productKey += e.KeyChar;
            }
            this.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Console.WriteLine(productKey);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
