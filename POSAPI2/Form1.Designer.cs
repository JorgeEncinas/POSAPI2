﻿namespace POSAPI2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.labelTotal = new System.Windows.Forms.Label();
            this.dgvSaldo = new System.Windows.Forms.DataGridView();
            this.btn100 = new System.Windows.Forms.Button();
            this.btn200 = new System.Windows.Forms.Button();
            this.btn300 = new System.Windows.Forms.Button();
            this.panelSaldo = new System.Windows.Forms.Panel();
            this.lbMonto = new System.Windows.Forms.Label();
            this.lbMontoTxt = new System.Windows.Forms.Label();
            this.lbNum2 = new System.Windows.Forms.Label();
            this.lbNum1 = new System.Windows.Forms.Label();
            this.tbNumTel2 = new System.Windows.Forms.TextBox();
            this.tbNumTel = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lbTotalName = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnChSaldo = new System.Windows.Forms.Button();
            this.lbAtiende = new System.Windows.Forms.Label();
            this.namelb = new System.Windows.Forms.Label();
            this.salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaldo)).BeginInit();
            this.panelSaldo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AllowUserToResizeColumns = false;
            this.dgv1.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv1.BackgroundColor = System.Drawing.Color.White;
            this.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle21;
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
            // dgvSaldo
            // 
            this.dgvSaldo.AllowUserToAddRows = false;
            this.dgvSaldo.AllowUserToDeleteRows = false;
            this.dgvSaldo.AllowUserToResizeColumns = false;
            this.dgvSaldo.AllowUserToResizeRows = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSaldo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvSaldo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSaldo.BackgroundColor = System.Drawing.Color.White;
            this.dgvSaldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSaldo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSaldo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvSaldo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSaldo.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgvSaldo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvSaldo.Location = new System.Drawing.Point(15, 51);
            this.dgvSaldo.MultiSelect = false;
            this.dgvSaldo.Name = "dgvSaldo";
            this.dgvSaldo.ReadOnly = true;
            this.dgvSaldo.RowHeadersVisible = false;
            this.dgvSaldo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvSaldo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSaldo.Size = new System.Drawing.Size(239, 116);
            this.dgvSaldo.TabIndex = 4;
            this.dgvSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvSaldo_KeyPress);
            // 
            // btn100
            // 
            this.btn100.Location = new System.Drawing.Point(15, 22);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(75, 23);
            this.btn100.TabIndex = 1;
            this.btn100.Tag = "100";
            this.btn100.Text = "$100.00";
            this.btn100.UseVisualStyleBackColor = true;
            this.btn100.Click += new System.EventHandler(this.addSaldo);
            // 
            // btn200
            // 
            this.btn200.Location = new System.Drawing.Point(96, 22);
            this.btn200.Name = "btn200";
            this.btn200.Size = new System.Drawing.Size(75, 23);
            this.btn200.TabIndex = 2;
            this.btn200.Tag = "200";
            this.btn200.Text = "$200.00";
            this.btn200.UseVisualStyleBackColor = true;
            this.btn200.Click += new System.EventHandler(this.addSaldo);
            // 
            // btn300
            // 
            this.btn300.Location = new System.Drawing.Point(179, 22);
            this.btn300.Name = "btn300";
            this.btn300.Size = new System.Drawing.Size(75, 23);
            this.btn300.TabIndex = 3;
            this.btn300.Tag = "300";
            this.btn300.Text = "$300.00";
            this.btn300.UseVisualStyleBackColor = true;
            this.btn300.Click += new System.EventHandler(this.addSaldo);
            // 
            // panelSaldo
            // 
            this.panelSaldo.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panelSaldo.Controls.Add(this.lbMonto);
            this.panelSaldo.Controls.Add(this.lbMontoTxt);
            this.panelSaldo.Controls.Add(this.lbNum2);
            this.panelSaldo.Controls.Add(this.lbNum1);
            this.panelSaldo.Controls.Add(this.tbNumTel2);
            this.panelSaldo.Controls.Add(this.btn300);
            this.panelSaldo.Controls.Add(this.tbNumTel);
            this.panelSaldo.Controls.Add(this.btn200);
            this.panelSaldo.Controls.Add(this.btn100);
            this.panelSaldo.Controls.Add(this.dgvSaldo);
            this.panelSaldo.Controls.Add(this.btnCancel);
            this.panelSaldo.Controls.Add(this.btnOK);
            this.panelSaldo.Location = new System.Drawing.Point(129, 241);
            this.panelSaldo.Name = "panelSaldo";
            this.panelSaldo.Size = new System.Drawing.Size(729, 236);
            this.panelSaldo.TabIndex = 3;
            this.panelSaldo.Visible = false;
            // 
            // lbMonto
            // 
            this.lbMonto.AutoSize = true;
            this.lbMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonto.Location = new System.Drawing.Point(495, 173);
            this.lbMonto.Name = "lbMonto";
            this.lbMonto.Size = new System.Drawing.Size(58, 29);
            this.lbMonto.TabIndex = 9;
            this.lbMonto.Text = "0.00";
            this.lbMonto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbMontoTxt
            // 
            this.lbMontoTxt.AutoSize = true;
            this.lbMontoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMontoTxt.Location = new System.Drawing.Point(281, 173);
            this.lbMontoTxt.Name = "lbMontoTxt";
            this.lbMontoTxt.Size = new System.Drawing.Size(208, 29);
            this.lbMontoTxt.TabIndex = 8;
            this.lbMontoTxt.Text = "Monto por Insertar";
            this.lbMontoTxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbNum2
            // 
            this.lbNum2.AutoSize = true;
            this.lbNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNum2.Location = new System.Drawing.Point(361, 95);
            this.lbNum2.Name = "lbNum2";
            this.lbNum2.Size = new System.Drawing.Size(225, 29);
            this.lbNum2.TabIndex = 3;
            this.lbNum2.Text = "Confirme el número";
            this.lbNum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbNum2.Visible = false;
            // 
            // lbNum1
            // 
            this.lbNum1.AutoSize = true;
            this.lbNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNum1.Location = new System.Drawing.Point(260, 15);
            this.lbNum1.Name = "lbNum1";
            this.lbNum1.Size = new System.Drawing.Size(534, 29);
            this.lbNum1.TabIndex = 0;
            this.lbNum1.Text = "Ingrese el número celular del teléfono a recargar";
            this.lbNum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbNum1.Visible = false;
            // 
            // tbNumTel2
            // 
            this.tbNumTel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumTel2.Location = new System.Drawing.Point(416, 132);
            this.tbNumTel2.MaxLength = 10;
            this.tbNumTel2.Name = "tbNumTel2";
            this.tbNumTel2.Size = new System.Drawing.Size(100, 35);
            this.tbNumTel2.TabIndex = 2;
            this.tbNumTel2.Visible = false;
            this.tbNumTel2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumTel1_KeyPress);
            // 
            // tbNumTel
            // 
            this.tbNumTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumTel.Location = new System.Drawing.Point(416, 63);
            this.tbNumTel.MaxLength = 10;
            this.tbNumTel.Name = "tbNumTel";
            this.tbNumTel.Size = new System.Drawing.Size(100, 35);
            this.tbNumTel.TabIndex = 1;
            this.tbNumTel.Visible = false;
            this.tbNumTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumTel1_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(135, 173);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancelButtons);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(34, 173);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.showDGV);
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
            this.btnChSaldo.Location = new System.Drawing.Point(890, 547);
            this.btnChSaldo.Name = "btnChSaldo";
            this.btnChSaldo.Size = new System.Drawing.Size(110, 55);
            this.btnChSaldo.TabIndex = 5;
            this.btnChSaldo.Text = "SALDO";
            this.btnChSaldo.UseVisualStyleBackColor = true;
            this.btnChSaldo.Click += new System.EventHandler(this.btnChSaldo_Click);
            // 
            // lbAtiende
            // 
            this.lbAtiende.AutoSize = true;
            this.lbAtiende.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAtiende.Location = new System.Drawing.Point(191, 12);
            this.lbAtiende.Name = "lbAtiende";
            this.lbAtiende.Size = new System.Drawing.Size(148, 31);
            this.lbAtiende.TabIndex = 7;
            this.lbAtiende.Text = "Le atiende:";
            // 
            // namelb
            // 
            this.namelb.AutoSize = true;
            this.namelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelb.Location = new System.Drawing.Point(359, 12);
            this.namelb.Name = "namelb";
            this.namelb.Size = new System.Drawing.Size(165, 31);
            this.namelb.TabIndex = 6;
            this.namelb.Text = "User\'s name";
            // 
            // salir
            // 
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Location = new System.Drawing.Point(12, 12);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 8;
            this.salir.Text = "button1";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1012, 628);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.lbAtiende);
            this.Controls.Add(this.namelb);
            this.Controls.Add(this.btnChSaldo);
            this.Controls.Add(this.lbTotalName);
            this.Controls.Add(this.panelSaldo);
            this.Controls.Add(this.pbLogo);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaldo)).EndInit();
            this.panelSaldo.ResumeLayout(false);
            this.panelSaldo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Panel panelSaldo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lbTotalName;
        private System.Windows.Forms.DataGridView dgvSaldo;
        private System.Windows.Forms.Button btn300;
        private System.Windows.Forms.Button btn200;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Button btnChSaldo;
        private System.Windows.Forms.Label lbNum2;
        private System.Windows.Forms.Label lbNum1;
        private System.Windows.Forms.TextBox tbNumTel2;
        private System.Windows.Forms.TextBox tbNumTel;
        private System.Windows.Forms.Label lbAtiende;
        private System.Windows.Forms.Label lbMonto;
        private System.Windows.Forms.Label lbMontoTxt;
        private System.Windows.Forms.Label namelb;
        private System.Windows.Forms.Button salir;
    }
}

