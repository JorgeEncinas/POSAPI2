
namespace POSAPI2
{
    partial class Reportes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoMásVendidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoMenosVendidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedorConMásVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedorConMenosVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorDíaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorSaldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cortesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corteXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corteZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvRte = new System.Windows.Forms.DataGridView();
            this.lbRte = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRte)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.cortesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.menuPrincipalToolStripMenuItem.Text = "Menu Principal";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(123, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoMásVendidoToolStripMenuItem,
            this.productoMenosVendidoToolStripMenuItem,
            this.vendedorConMásVentasToolStripMenuItem,
            this.vendedorConMenosVentasToolStripMenuItem,
            this.ventasPorDíaToolStripMenuItem,
            this.ventasPorSaldoToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // productoMásVendidoToolStripMenuItem
            // 
            this.productoMásVendidoToolStripMenuItem.Name = "productoMásVendidoToolStripMenuItem";
            this.productoMásVendidoToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.productoMásVendidoToolStripMenuItem.Tag = "0";
            this.productoMásVendidoToolStripMenuItem.Text = "Producto más vendido";
            this.productoMásVendidoToolStripMenuItem.Click += new System.EventHandler(this.getReporte);
            // 
            // productoMenosVendidoToolStripMenuItem
            // 
            this.productoMenosVendidoToolStripMenuItem.Name = "productoMenosVendidoToolStripMenuItem";
            this.productoMenosVendidoToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.productoMenosVendidoToolStripMenuItem.Tag = "1";
            this.productoMenosVendidoToolStripMenuItem.Text = "Producto menos vendido";
            this.productoMenosVendidoToolStripMenuItem.Click += new System.EventHandler(this.getReporte);
            // 
            // vendedorConMásVentasToolStripMenuItem
            // 
            this.vendedorConMásVentasToolStripMenuItem.Name = "vendedorConMásVentasToolStripMenuItem";
            this.vendedorConMásVentasToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.vendedorConMásVentasToolStripMenuItem.Tag = "2";
            this.vendedorConMásVentasToolStripMenuItem.Text = "Vendedor con más ventas";
            this.vendedorConMásVentasToolStripMenuItem.Click += new System.EventHandler(this.getReporte);
            // 
            // vendedorConMenosVentasToolStripMenuItem
            // 
            this.vendedorConMenosVentasToolStripMenuItem.Name = "vendedorConMenosVentasToolStripMenuItem";
            this.vendedorConMenosVentasToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.vendedorConMenosVentasToolStripMenuItem.Tag = "3";
            this.vendedorConMenosVentasToolStripMenuItem.Text = "Vendedor con menos ventas";
            this.vendedorConMenosVentasToolStripMenuItem.Click += new System.EventHandler(this.getReporte);
            // 
            // ventasPorDíaToolStripMenuItem
            // 
            this.ventasPorDíaToolStripMenuItem.Name = "ventasPorDíaToolStripMenuItem";
            this.ventasPorDíaToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.ventasPorDíaToolStripMenuItem.Tag = "4";
            this.ventasPorDíaToolStripMenuItem.Text = "Ventas por día";
            this.ventasPorDíaToolStripMenuItem.Click += new System.EventHandler(this.getReporte);
            // 
            // ventasPorSaldoToolStripMenuItem
            // 
            this.ventasPorSaldoToolStripMenuItem.Name = "ventasPorSaldoToolStripMenuItem";
            this.ventasPorSaldoToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.ventasPorSaldoToolStripMenuItem.Tag = "5";
            this.ventasPorSaldoToolStripMenuItem.Text = "Ventas por saldo";
            this.ventasPorSaldoToolStripMenuItem.Click += new System.EventHandler(this.getReporte);
            // 
            // cortesToolStripMenuItem
            // 
            this.cortesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.corteXToolStripMenuItem,
            this.corteZToolStripMenuItem});
            this.cortesToolStripMenuItem.Name = "cortesToolStripMenuItem";
            this.cortesToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.cortesToolStripMenuItem.Text = "Cortes";
            // 
            // corteXToolStripMenuItem
            // 
            this.corteXToolStripMenuItem.Name = "corteXToolStripMenuItem";
            this.corteXToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.corteXToolStripMenuItem.Text = "Corte X";
            // 
            // corteZToolStripMenuItem
            // 
            this.corteZToolStripMenuItem.Name = "corteZToolStripMenuItem";
            this.corteZToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.corteZToolStripMenuItem.Text = "Corte Z";
            // 
            // dgvRte
            // 
            this.dgvRte.AllowUserToAddRows = false;
            this.dgvRte.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvRte.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRte.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRte.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRte.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRte.Location = new System.Drawing.Point(35, 112);
            this.dgvRte.MultiSelect = false;
            this.dgvRte.Name = "dgvRte";
            this.dgvRte.ReadOnly = true;
            this.dgvRte.RowHeadersVisible = false;
            this.dgvRte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRte.Size = new System.Drawing.Size(721, 270);
            this.dgvRte.TabIndex = 1;
            this.dgvRte.Visible = false;
            // 
            // lbRte
            // 
            this.lbRte.AutoSize = true;
            this.lbRte.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRte.Location = new System.Drawing.Point(28, 45);
            this.lbRte.Name = "lbRte";
            this.lbRte.Size = new System.Drawing.Size(90, 37);
            this.lbRte.TabIndex = 2;
            this.lbRte.Text = "lbRte";
            this.lbRte.Visible = false;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbRte);
            this.Controls.Add(this.dgvRte);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoMásVendidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoMenosVendidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedorConMásVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedorConMenosVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasPorDíaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cortesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corteXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corteZToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvRte;
        private System.Windows.Forms.Label lbRte;
        private System.Windows.Forms.ToolStripMenuItem ventasPorSaldoToolStripMenuItem;
    }
}