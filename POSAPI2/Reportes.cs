using MySql.Data.MySqlClient;
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
    public partial class Reportes : Form
    {
        private DBConnection dbconn;
        private Dictionary<int, Tuple<string, Action>> queries;
        public Reportes()
        {
            InitializeComponent();
            dbconn = new DBConnection();
            queries = new Dictionary<int, Tuple<string, Action>>();
            
        }

        private void setLayout()
        {
            double screenWidth = Screen.GetWorkingArea(this).Width;
            double screenHeight = Screen.GetWorkingArea(this).Height;
            //MessageBox.Show("WIDTH: " + screenWidth + ", HEIGHT: " + screenHeight);
            dgvRte.Size = new Size(Convert.ToInt32(screenWidth * 0.90), Convert.ToInt32(screenHeight * 0.84));
            dgvRte.Location = new Point(Convert.ToInt32((screenWidth * 0.50) - (dgvRte.Width * 0.50)),
                                        Convert.ToInt32(screenHeight * 0.15));
            lbRte.Location = new Point(Convert.ToInt32((screenWidth * 0.10)),
                                       Convert.ToInt32(screenHeight * 0.08));
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            setLayout();
            queries.Add(0, new Tuple<string, Action>("rte-prod-mas-vendido", rteMenosVentas));
            queries.Add(1, new Tuple<string, Action>("rte-prod-menos-vendido", rteProdMenosVendido));
            queries.Add(2, new Tuple<string, Action>("rte_vdor_mas_ventas", rteVdorMasVentas));
            queries.Add(3, new Tuple<string, Action>("rte_vdor_menos_ventas", rteVdorMenosVentas));
            queries.Add(4, new Tuple<string, Action>("rte-vtas-por-dia", rteVtasPorDia));
            queries.Add(5, new Tuple<string, Action>("rte-vtas-por-saldo", rteVtasPorSaldo));
        }

        public void getReporte(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = sender as ToolStripMenuItem;
            dgvRte.DataSource = null;
            dgvRte.Rows.Clear();
            dgvRte.Columns.Clear();
            lbRte.Text = tsmi.Text;
            Tuple<string, Action> tuple = queries[Convert.ToInt32(tsmi.Tag)];
            string queryView = tuple.Item1;
            string query = "SELECT * FROM `" + queryView + "`;";
            try
            {
                MySqlDataReader reader = dbconn.queryProduct(query);
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvRte.DataSource = dt;
                dgvRte.ReadOnly = true;
                tuple.Item2.Invoke();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            dgvRte.Visible = true;
            dgvRte.Visible = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rteMenosVentas()
        {

        }
        private void rteProdMenosVendido()
        {

        }
        private void rteVdorMasVentas()
        {

        }
        private void rteVdorMenosVentas()
        {

        }
        private void rteVtasPorDia()
        { //Size first, place second
            LayUtil.sizeToSuperior(this, dgvRte, 0.50, 0.50);
            LayUtil.placeOnSuperior(this, dgvRte, 0.50, 0.50, 0.20, 0);
            dgvRte.Columns[0].Width = Convert.ToInt32(dgvRte.Width * 0.20);
            dgvRte.Columns[1].Width = Convert.ToInt32(dgvRte.Width * 0.80);
        }
        private void rteVtasPorSaldo()
        {

        }
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deja ahí");
        }
    }
}
