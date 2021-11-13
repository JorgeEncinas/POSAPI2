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
        private int idUsuario;
        private string nombreUsuario;

        public Form1(int idUsuario, string nombreUsuario)
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
            dgvSaldo.Columns.Add("id","id");
            dgvSaldo.Columns.Add("cantidad", "Cantidad");
            dgvSaldo.Columns.Add("nombre", "Nombre");
            dgvSaldo.Columns.Add("precio", "Precio");
            dgvSaldo.Columns.Add("total", "Total");
            dgvSaldo.Columns["id"].DisplayIndex = 0;
            dgvSaldo.Columns["cantidad"].DisplayIndex = 1;
            dgvSaldo.Columns["nombre"].DisplayIndex = 2;
            dgvSaldo.Columns["precio"].DisplayIndex = 3;
            dgvSaldo.Columns["total"].DisplayIndex = 4;
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            namelb.Text = this.nombreUsuario;
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
            dgvSaldo.Columns["id"].Visible = false;
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
            sizeToSuperior(this, btnChSaldo, 0.10, 0.10);
            btnChSaldo.Location = new Point(Convert.ToInt32(this.Width * 0.88),
                                            Convert.ToInt32(this.Height * 0.88));
            //Saldos window
            sizeToSuperior(this, panelSaldo, 0.90, 0.90);
            sizeToSuperior(panelSaldo, btn100, 0.20, 0.15);
            sizeToSuperior(panelSaldo, btn200, 0.20, 0.15);
            sizeToSuperior(panelSaldo, btn300, 0.20, 0.15);
            sizeToSuperior(panelSaldo, dgvSaldo, 0.65, 0.90);
            sizeToSuperior(panelSaldo, btnOK, 0.15, 0.10);
            sizeToSuperior(panelSaldo, btnCancel, 0.15, 0.10);
            dgvSaldo.Columns["cantidad"].Width = Convert.ToInt32(dgvSaldo.Width * 0.20);
            dgvSaldo.Columns["nombre"].Width = Convert.ToInt32(dgvSaldo.Width * 0.40);
            dgvSaldo.Columns["precio"].Width = Convert.ToInt32(dgvSaldo.Width * 0.20);
            dgvSaldo.Columns["total"].Width = Convert.ToInt32(dgvSaldo.Width * 0.20);
            sizeToSuperior(panelSaldo, lbNum1, 0.90, 0.30);
            sizeToSuperior(panelSaldo, lbNum2, 0.90, 0.30);
            sizeToSuperior(panelSaldo, tbNumTel, 0.20, 0.30);
            sizeToSuperior(panelSaldo, tbNumTel2, 0.20, 0.30);
            placeOnSuperior(panelSaldo, lbMontoTxt, 0.70, 0.0, 0.75, 0.50);
            placeOnSuperior(panelSaldo, lbMonto, 0.73, 0.0, 0.80, 0.50);
            placeOnSuperior(this, panelSaldo, 0.50, 0.50, 0.50, 0.50);
            placeOnSuperior(panelSaldo, dgvSaldo, 0.010, 0, 0.08, 0);
            placeOnSuperior(panelSaldo, btn100, 0.20, 0.50, 0.30, 0.50);
            placeOnSuperior(panelSaldo, btn200, 0.50, 0.50, 0.30, 0.50);
            placeOnSuperior(panelSaldo, btn300, 0.80, 0.50, 0.30, 0.50);
            placeOnSuperior(panelSaldo, btnOK, 0.75, 0.50, 0.90, 0.50);
            placeOnSuperior(panelSaldo, btnCancel, 0.90, 0.50, 0.90, 0.50);
            dgvSaldo.Visible = false;
            namelb.Location = new Point(lbAtiende.Location.X + lbAtiende.Width + 10, lbAtiende.Location.Y);
        }

        private void placeOnSuperior(Control superior, Control inferior, double sPercentageX, double iPercentageX, double sPercentageY, double iPercentageY)
        {
            inferior.Location = new Point(
                    Convert.ToInt32((superior.Width*sPercentageX) - (inferior.Width*iPercentageX)),
                    Convert.ToInt32((superior.Height*sPercentageY) - (inferior.Height*iPercentageY)));
        }

        private void sizeToSuperior(Control superior, Control inferior, double percentageX, double percentageY)
        {
            inferior.Size = new Size(Convert.ToInt32(superior.Width * percentageX),
                                     Convert.ToInt32(superior.Height * percentageY));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setLayout();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 13)
            {
                if (!productKey.Equals(""))
                {
                    String query = "SELECT * FROM productos WHERE clave =" + productKey;
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
                                    i = -1;
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
                        DialogResult result = MessageBox.Show($"¿Completar la transacción? {productKey} {total} {Environment.NewLine} ",
                                        "Título",
                                        MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            double recibido = 0;
                            if (Double.TryParse(productKey, out recibido))
                            {
                                if (recibido >= total)
                                {
                                    GetChange(recibido);
                                    string queryInsert = "INSERT INTO ventas(idUsuario, total, recibido) VALUES(" + idUsuario + ", " + total + ", " + recibido + ")";
                                    dbconn.executeNonQuery(queryInsert);
                                    string queryID = "SELECT LAST_INSERT_ID()";
                                    int ventaID = dbconn.executeScalar(queryID);
                                    string queryProducto = "";
                                    foreach (DataGridViewRow row in dgv1.Rows)
                                    {
                                        queryProducto = "INSERT INTO ventadetalle(idVenta, idProducto, cantidad) VALUES(" + ventaID + ", " + row.Cells["id"].Value.ToString() + ", " + row.Cells["cantidad"].Value.ToString() + ")";
                                        dbconn.executeNonQuery(queryProducto);
                                    }
                                    dgv1.Rows.Clear();
                                    labelTotal.Text = "";
                                } else
                                {
                                    MessageBox.Show("No le alcanza");
                                }
                                
                            }
                        } 
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("Ha ocurrido un error al realizar el pago y se ha abortado la operación.");
                        MessageBox.Show(ex.ToString());
                    }
                    productKey = "";
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

        private void btnAddSaldo_Click(object sender, EventArgs e, Control control)
        {
            Button temp = (Button)sender;
            int saldo = 0;
            if(temp!= null)
            {
                saldo = Convert.ToInt32(temp.Tag);
            }
        }

        private void addSaldo(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            double btnValue = Convert.ToDouble(btn.Tag);
            bool encontrado = false;
            for (int i = dgvSaldo.Rows.Count - 1; i > -1; i--)
            {
                if (Convert.ToDouble(dgvSaldo.Rows[i].Cells["id"].Value) == btnValue) //Compare name
                {
                    int cantidad = Int32.Parse(dgvSaldo.Rows[i].Cells["cantidad"].Value.ToString());
                    //double nuevoTotal = Double.Parse(dgvSaldo.Rows[i].Cells["precio"].Value.ToString());
                    double nuevoTotal = (cantidad + 1) * btnValue;
                    dgvSaldo.Rows[i].Cells["cantidad"].Value = cantidad + 1;
                    dgvSaldo.Rows[i].Cells["total"].Value = nuevoTotal;
                    double monto = Double.Parse(lbMonto.Text) + btnValue;
                    lbMonto.Text = monto.ToString("0.00");
                    encontrado = true;
                    dgvSaldo.Rows[i].Selected = true;
                    i = -1;
                }
            }
            if (encontrado == false)
            {
                dgvSaldo.Rows.Add(Convert.ToInt32(btnValue), 1, "Saldo " + btnValue.ToString(), String.Format("{0:0.00}", btnValue), String.Format("{0:0.00}", btnValue));
                double monto = Double.Parse(lbMonto.Text);
                monto += btnValue;
                lbMonto.Text = monto.ToString("0.00");
            }
        }

        private void btnChSaldo_Click(object sender, EventArgs e)
        {
            panelSaldo.Visible = true;
            panelSaldo.BringToFront();
            btnChSaldo.TabStop = false;
            this.KeyPress -= this.Form1_KeyPress;
            dgv1.Enabled = false;
        }

        private void btnCancelButtons(object sender, EventArgs e)
        { //Cancelar
            panelSaldo.Visible = false;
            btnChSaldo.TabStop = true;
            this.KeyPress += Form1_KeyPress;
            dgv1.Enabled = true;
        }

        private void showDGV(object sender, EventArgs e)
        { //Mostrar los saldos
            dgvSaldo.Visible = true;
            btn100.Visible = false;
            btn200.Visible = false;
            btn300.Visible = false;
            btnOK.Click += this.showPhone;
            btnOK.Click -= this.showDGV;
            btnCancel.Click += this.cancelDGV;
            btnCancel.Click -= this.btnCancelButtons;
        }

        private void cancelDGV(object sender, EventArgs e)
        { //Cancelar y mostrar los 3 botones
            dgvSaldo.Visible = false;
            btn100.Visible = true;
            btn200.Visible = true;
            btn300.Visible = true;
             btnOK.Click -= this.showPhone;
            btnOK.Click += this.showDGV;
            btnCancel.Click -= this.cancelDGV;
            btnCancel.Click += this.btnCancelButtons;
            dgvSaldo.Rows.Clear();
        }

        private void showPhone(object sender, EventArgs e)
        { //Mostrar el input de teléfono
            dgvSaldo.Visible = false;
            tbNumTel.Visible = true;
            tbNumTel2.Visible = true;
            lbNum1.Visible = true;
            lbNum2.Visible = true;
             btnOK.Click -= this.showPhone; //Pongo el método que quiero que ejecute
            btnOK.Click += this.confirmPhone; //Quito el método que ya no vamos a utilizar
            btnCancel.Click += this.cancelPhone;
            btnCancel.Click -= this.cancelDGV;
        }

        private void confirmPhone(object sender, EventArgs e)
        {
            if (tbNumTel.Text != "" && tbNumTel2.Text != "")
            {
                if (tbNumTel.Text == tbNumTel2.Text)
                {
                    string message = "Saldo agregado correctamente";  
                    string title = "Exito";  
                    MessageBox.Show(message, title);
                    resetPanelSaldo();
                } else
                {
                    string message = "Los numeros no son iguales";  
                    string title = "Exito";  
                    MessageBox.Show(message, title);
                }
                
            } else
            {
                string message = "Favor de llenar todos los campos";  
                string title = "Error";  
                MessageBox.Show(message, title);
            }
            resetPanelSaldo();
        }

        private void cancelPhone(object sender, EventArgs e)
        { //Volver al DGV
            dgvSaldo.Visible = true;
            tbNumTel.Visible = false;
            tbNumTel2.Visible = false;
            lbNum1.Visible = false;
            lbNum2.Visible = false;
            tbNumTel.Text = "";
            tbNumTel2.Text = "";
            btnOK.Click += this.showPhone;
            btnOK.Click -= this.confirmPhone;
            btnCancel.Click -= this.cancelPhone;
            btnCancel.Click += this.cancelDGV;
        }

        private void resetPanelSaldo()
        {
            tbNumTel.Visible = false;
            tbNumTel2.Visible = false;
            lbNum1.Visible = false;
            lbNum2.Visible = false;
            tbNumTel.Text = "";
            tbNumTel2.Text = "";
            btn100.Visible = true;
            btn200.Visible = true;
            btn300.Visible = true;
            btnCancel.Click -= this.cancelPhone;
            btnCancel.Click += this.btnCancelButtons;
            btnOK.Click -= this.confirmPhone;
            btnOK.Click += showDGV;
            dgvSaldo.Rows.Clear();
            panelSaldo.Visible = false;
            this.KeyPress += this.Form1_KeyPress;
            dgv1.Enabled = true;
            btnChSaldo.TabStop = true;
            lbMonto.Text = "";
        }

        private void getTotalSaldo()
        {
            double totalSaldo = 0;
            foreach (DataGridViewRow row in dgvSaldo.Rows)
            {
                totalSaldo += (Double.Parse(row.Cells[3].Value.ToString())) * (Double.Parse(row.Cells[1].Value.ToString()));
            }
            lbMonto.Text = totalSaldo.ToString();
        }

        private void dgvSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 && dgvSaldo.Rows.Count > 0)
            {
                DataGridViewRow item = dgvSaldo.SelectedRows[0];
                MessageBox.Show($"Se eliminará el producto {item.Cells[2].Value.ToString()}");
                double saldoUnitario = Convert.ToDouble(item.Cells[0].Value);
                double monto2 = Double.Parse(lbMonto.Text) - saldoUnitario;
                lbMonto.Text = monto2.ToString();
                int itemQuantity = Convert.ToInt32(item.Cells[1].Value);
                if (itemQuantity > 1)
                {
                    item.Cells[1].Value = itemQuantity - 1;
                    item.Cells[4].Value = (itemQuantity - 1) * saldoUnitario;
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
                    dgvSaldo.Rows[nuevoIndice].Selected = true;
                    dgvSaldo.Rows.RemoveAt(item.Index);
                }
                //getTotalSaldo();
            }

        }
    }
}
