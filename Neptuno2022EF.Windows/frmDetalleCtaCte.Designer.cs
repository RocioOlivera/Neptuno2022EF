namespace Neptuno2022EF.Windows
{
    partial class frmDetalleCtaCte
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
            this.EncabezadoPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDebe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHaber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIngresarPago = new System.Windows.Forms.Button();
            this.EncabezadoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // EncabezadoPanel
            // 
            this.EncabezadoPanel.BackColor = System.Drawing.Color.LightGray;
            this.EncabezadoPanel.Controls.Add(this.label1);
            this.EncabezadoPanel.Controls.Add(this.txtCliente);
            this.EncabezadoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EncabezadoPanel.Location = new System.Drawing.Point(0, 0);
            this.EncabezadoPanel.Margin = new System.Windows.Forms.Padding(4);
            this.EncabezadoPanel.Name = "EncabezadoPanel";
            this.EncabezadoPanel.Size = new System.Drawing.Size(800, 97);
            this.EncabezadoPanel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(292, 40);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(317, 22);
            this.txtCliente.TabIndex = 1;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFecha,
            this.colMovimiento,
            this.colDebe,
            this.colHaber});
            this.dgvDatos.Location = new System.Drawing.Point(13, 114);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.Size = new System.Drawing.Size(646, 258);
            this.dgvDatos.TabIndex = 4;
            // 
            // colFecha
            // 
            this.colFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.MinimumWidth = 6;
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colMovimiento
            // 
            this.colMovimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colMovimiento.DefaultCellStyle = dataGridViewCellStyle1;
            this.colMovimiento.HeaderText = "Movimiento";
            this.colMovimiento.MinimumWidth = 6;
            this.colMovimiento.Name = "colMovimiento";
            this.colMovimiento.ReadOnly = true;
            // 
            // colDebe
            // 
            this.colDebe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colDebe.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDebe.HeaderText = "Debe";
            this.colDebe.MinimumWidth = 6;
            this.colDebe.Name = "colDebe";
            this.colDebe.ReadOnly = true;
            this.colDebe.Width = 70;
            // 
            // colHaber
            // 
            this.colHaber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colHaber.DefaultCellStyle = dataGridViewCellStyle3;
            this.colHaber.HeaderText = "Haber";
            this.colHaber.MinimumWidth = 6;
            this.colHaber.Name = "colHaber";
            this.colHaber.ReadOnly = true;
            this.colHaber.Width = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 389);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Saldo:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Location = new System.Drawing.Point(516, 386);
            this.txtSaldo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(143, 22);
            this.txtSaldo.TabIndex = 6;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(117, 396);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(83, 42);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Aceptar";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(222, 396);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 42);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnIngresarPago
            // 
            this.btnIngresarPago.Location = new System.Drawing.Point(691, 205);
            this.btnIngresarPago.Name = "btnIngresarPago";
            this.btnIngresarPago.Size = new System.Drawing.Size(83, 85);
            this.btnIngresarPago.TabIndex = 10;
            this.btnIngresarPago.Text = "Ingresar Pago";
            this.btnIngresarPago.UseVisualStyleBackColor = true;
            this.btnIngresarPago.Click += new System.EventHandler(this.btnIngresarPago_Click);
            // 
            // frmDetalleCtaCte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIngresarPago);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.EncabezadoPanel);
            this.Name = "frmDetalleCtaCte";
            this.Text = "Detalle CtaCte";
            this.Load += new System.EventHandler(this.frmDetalleCtaCte_Load);
            this.EncabezadoPanel.ResumeLayout(false);
            this.EncabezadoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel EncabezadoPanel;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDebe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHaber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIngresarPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCliente;
    }
}