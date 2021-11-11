namespace POSAPI2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelPay = new System.Windows.Forms.Panel();
            this.btn300 = new System.Windows.Forms.Button();
            this.btn200 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.dgvSaldo = new System.Windows.Forms.DataGridView();
            this.lbSecond = new System.Windows.Forms.Label();
            this.lbMsg = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lbTotalName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnChSaldo = new System.Windows.Forms.Button();
            this.namelb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.panelPay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AllowUserToResizeColumns = false;
            this.dgv1.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv1.BackgroundColor = System.Drawing.Color.White;
            this.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgv1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv1.Location = new System.Drawing.Point(64, 140);
            this.dgv1.MultiSelect = false;
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(820, 436);
            this.dgv1.TabIndex = 0;
            this.dgv1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgv1_KeyPress);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(258, 91);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(86, 31);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 582);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Visible = false;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // panelPay
            // 
            this.panelPay.Controls.Add(this.btn300);
            this.panelPay.Controls.Add(this.btn200);
            this.panelPay.Controls.Add(this.btn100);
            this.panelPay.Controls.Add(this.dgvSaldo);
            this.panelPay.Controls.Add(this.lbSecond);
            this.panelPay.Controls.Add(this.lbMsg);
            this.panelPay.Controls.Add(this.btnCancel);
            this.panelPay.Controls.Add(this.btnOK);
            this.panelPay.Location = new System.Drawing.Point(199, 157);
            this.panelPay.Name = "panelPay";
            this.panelPay.Size = new System.Drawing.Size(650, 419);
            this.panelPay.TabIndex = 3;
            this.panelPay.Visible = false;
            // 
            // btn300
            // 
            this.btn300.Location = new System.Drawing.Point(463, 59);
            this.btn300.Name = "btn300";
            this.btn300.Size = new System.Drawing.Size(75, 23);
            this.btn300.TabIndex = 7;
            this.btn300.Text = "$300.00";
            this.btn300.UseVisualStyleBackColor = true;
            // 
            // btn200
            // 
            this.btn200.Location = new System.Drawing.Point(280, 59);
            this.btn200.Name = "btn200";
            this.btn200.Size = new System.Drawing.Size(75, 23);
            this.btn200.TabIndex = 6;
            this.btn200.Text = "$200.00";
            this.btn200.UseVisualStyleBackColor = true;
            // 
            // btn100
            // 
            this.btn100.Location = new System.Drawing.Point(98, 59);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(75, 23);
            this.btn100.TabIndex = 5;
            this.btn100.Text = "$100.00";
            this.btn100.UseVisualStyleBackColor = true;
            // 
            // dgvSaldo
            // 
            this.dgvSaldo.AllowUserToAddRows = false;
            this.dgvSaldo.AllowUserToDeleteRows = false;
            this.dgvSaldo.AllowUserToResizeColumns = false;
            this.dgvSaldo.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSaldo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvSaldo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSaldo.BackgroundColor = System.Drawing.Color.White;
            this.dgvSaldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSaldo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSaldo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvSaldo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSaldo.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvSaldo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvSaldo.Location = new System.Drawing.Point(179, 118);
            this.dgvSaldo.MultiSelect = false;
            this.dgvSaldo.Name = "dgvSaldo";
            this.dgvSaldo.ReadOnly = true;
            this.dgvSaldo.RowHeadersVisible = false;
            this.dgvSaldo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvSaldo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSaldo.Size = new System.Drawing.Size(327, 116);
            this.dgvSaldo.TabIndex = 4;
            // 
            // lbSecond
            // 
            this.lbSecond.AutoSize = true;
            this.lbSecond.Location = new System.Drawing.Point(83, 232);
            this.lbSecond.Name = "lbSecond";
            this.lbSecond.Size = new System.Drawing.Size(90, 13);
            this.lbSecond.TabIndex = 3;
            this.lbSecond.Text = "Second Message";
            // 
            // lbMsg
            // 
            this.lbMsg.AutoSize = true;
            this.lbMsg.Location = new System.Drawing.Point(97, 202);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(76, 13);
            this.lbMsg.TabIndex = 2;
            this.lbMsg.Text = "Main Message";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(345, 255);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(238, 255);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // lbTotalName
            // 
            this.lbTotalName.AutoSize = true;
            this.lbTotalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalName.Location = new System.Drawing.Point(123, 91);
            this.lbTotalName.Name = "lbTotalName";
            this.lbTotalName.Size = new System.Drawing.Size(83, 31);
            this.lbTotalName.TabIndex = 4;
            this.lbTotalName.Text = "Total:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::POSAPI2.Properties.Resources.placeholder_logo2;
            this.pbLogo.Location = new System.Drawing.Point(743, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(257, 95);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // btnChSaldo
            // 
            this.btnChSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChSaldo.Location = new System.Drawing.Point(890, 561);
            this.btnChSaldo.Name = "btnChSaldo";
            this.btnChSaldo.Size = new System.Drawing.Size(110, 55);
            this.btnChSaldo.TabIndex = 5;
            this.btnChSaldo.Text = "AGREGAR\r\nSALDO\r\n";
            this.btnChSaldo.UseVisualStyleBackColor = true;
            // 
            // namelb
            // 
            this.namelb.AutoSize = true;
            this.namelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelb.Location = new System.Drawing.Point(64, 12);
            this.namelb.Name = "namelb";
            this.namelb.Size = new System.Drawing.Size(165, 31);
            this.namelb.TabIndex = 6;
            this.namelb.Text = "User\'s name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1012, 628);
            this.Controls.Add(this.namelb);
            this.Controls.Add(this.btnChSaldo);
            this.Controls.Add(this.lbTotalName);
            this.Controls.Add(this.panelPay);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.dgv1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.panelPay.ResumeLayout(false);
            this.panelPay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelPay;
        private System.Windows.Forms.Label lbSecond;
        private System.Windows.Forms.Label lbMsg;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lbTotalName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgvSaldo;
        private System.Windows.Forms.Button btn300;
        private System.Windows.Forms.Button btn200;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Button btnChSaldo;
        private System.Windows.Forms.Label namelb;
    }
}

