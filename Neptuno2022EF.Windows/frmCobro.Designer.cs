﻿namespace Neptuno2022EF.Windows
{
    partial class frmCobro
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblImporteACobrar = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtImporteRecibido = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSaldoRestante = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblImporteACobrar);
            this.groupBox1.Location = new System.Drawing.Point(65, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Importe a cobrar";
            // 
            // lblImporteACobrar
            // 
            this.lblImporteACobrar.AutoSize = true;
            this.lblImporteACobrar.BackColor = System.Drawing.SystemColors.Window;
            this.lblImporteACobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteACobrar.Location = new System.Drawing.Point(67, 28);
            this.lblImporteACobrar.Name = "lblImporteACobrar";
            this.lblImporteACobrar.Size = new System.Drawing.Size(74, 36);
            this.lblImporteACobrar.TabIndex = 0;
            this.lblImporteACobrar.Text = "0.00";
            this.lblImporteACobrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtImporteRecibido);
            this.groupBox2.Location = new System.Drawing.Point(65, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 77);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Importe recibido";
            // 
            // txtImporteRecibido
            // 
            this.txtImporteRecibido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImporteRecibido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporteRecibido.Location = new System.Drawing.Point(19, 21);
            this.txtImporteRecibido.Name = "txtImporteRecibido";
            this.txtImporteRecibido.Size = new System.Drawing.Size(175, 34);
            this.txtImporteRecibido.TabIndex = 0;
            this.txtImporteRecibido.Text = "0.00";
            this.txtImporteRecibido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(39, 366);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(88, 48);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(209, 366);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 48);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.lblSaldoRestante);
            this.groupBox3.Location = new System.Drawing.Point(65, 262);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 77);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Saldo Restante";
            // 
            // lblSaldoRestante
            // 
            this.lblSaldoRestante.AutoSize = true;
            this.lblSaldoRestante.BackColor = System.Drawing.SystemColors.Window;
            this.lblSaldoRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoRestante.Location = new System.Drawing.Point(67, 28);
            this.lblSaldoRestante.Name = "lblSaldoRestante";
            this.lblSaldoRestante.Size = new System.Drawing.Size(74, 36);
            this.lblSaldoRestante.TabIndex = 0;
            this.lblSaldoRestante.Text = "0.00";
            this.lblSaldoRestante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCobro";
            this.Text = "Efectuar Pago";
            this.Load += new System.EventHandler(this.btnOk_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblImporteACobrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtImporteRecibido;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblSaldoRestante;
    }
}