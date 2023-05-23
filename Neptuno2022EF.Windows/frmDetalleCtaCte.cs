using Neptuno2022EF.Entidades.Dtos.Cliente;
using Neptuno2022EF.Entidades.Dtos.CtaCte;
using Neptuno2022EF.Entidades.Dtos.DetalleCtaCte;
using Neptuno2022EF.Entidades.Dtos.DetalleVenta;
using Neptuno2022EF.Entidades.Dtos.Venta;
using Neptuno2022EF.Entidades.Entidades;
using Neptuno2022EF.Entidades.Enums;
using Neptuno2022EF.Servicios.Interfaces;
using Neptuno2022EF.Windows.Classes;
using Neptuno2022EF.Windows.Helpers;
using Neptuno2022EF.Windows.Helpers.Enum;
using NuevaAppComercial2022.Entidades.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Neptuno2022EF.Windows
{
    public partial class frmDetalleCtaCte : Form
    {
        private readonly IServiciosCtasCtes _servicio;
        private readonly IServiciosClientes servicioCliente;
        public frmDetalleCtaCte()
        {
            InitializeComponent();
        }

        //List<DetalleCtaCteListDto> lista;
        private ClienteListDto clienteListDto;
        private List<DetalleCtaCteListDto> lista;
        private ResumenCtaCteDto resumenCtaCteDto;

        private CtaCteDetalleDto detalleDto;
        public void SetCtaCte(CtaCteDetalleDto ctacteDetalleDto)
        {
            detalleDto = ctacteDetalleDto;
        }



        private void frmDetalleCtaCte_Load(object sender, EventArgs e)
        {

            txtCliente.Text = detalleDto.detalleCtaCte.First().Cliente;

            decimal SaldoDeudor= detalleDto.detalleCtaCte.Sum(x => x.Debe - x.Haber);
            txtSaldo.Text=SaldoDeudor.ToString();
            //txtSaldo.Text = detalleDto.detalleCtaCte.Sum(x => x.Debe - x.Haber).ToString();
            FormHelper.MostrarDatosEnGrilla<DetalleCtaCteListDto>(dgvDatos, detalleDto.detalleCtaCte);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnIngresarPago_Click(object sender, EventArgs e)
        {
            if (ValidarDatosSiAdeuda())
            {
                lblImporteACobrar.Enabled = true;
                txtImporteRecibido.Enabled = true;
                lblSaldoRestante.Enabled = true;
                btnCerrar.Enabled = false;
                btnIngresarPago.Enabled = false;
                btnCancelar.Enabled = true;
                btnOk.Enabled = true;

                lblImporteACobrar.Text = txtSaldo.Text;

            }

        }
        
        private bool ValidarDatosSiAdeuda()
        {
            errorProvider1.Clear();
            bool valido = true;
            decimal Saldo=decimal.Parse(txtSaldo.Text);

            if (Saldo == 0)
            {
                valido = false;
                errorProvider1.SetError(btnIngresarPago, "El cliente no posee deuda.");

            }

            return valido;
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //private string ConstruirMovimiento(CtaCte ctaCte, FormaPago forma)
        //{
        //    return $"PAGO {forma.ToString()} {ctaCte.CtaCteId}";

        //}

        private CtaCte ctaCte;
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (ctaCte == null)
                {
                    ctaCte = new CtaCte();
                }
                ctaCte.FechaMovimiento = DateTime.Now;
                ctaCte.Movimiento = $"PAGO Efectivo";
                ctaCte.Debe = decimal.Parse(lblImporteACobrar.Text) - decimal.Parse(txtImporteRecibido.Text);
                ctaCte.Haber = decimal.Parse(txtImporteRecibido.Text);
                ctaCte.Saldo = decimal.Parse(lblImporteACobrar.Text) - decimal.Parse(txtImporteRecibido.Text);
                ctaCte.Cliente = servicioCliente.GetClientePorId(resumenCtaCteDto.ClienteId);
                //ctaCte.Cliente = (Cliente)Tag;

                DialogResult = DialogResult.OK;

                MessageBox.Show("CtaCte agregada satisfactoriamente!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormHelper.MostrarDatosEnGrilla<DetalleCtaCteListDto>(dgvDatos, detalleDto.detalleCtaCte);
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (decimal.Parse(lblImporteACobrar.Text) <= 0)
            {
                valido = false;
                errorProvider1.SetError(lblImporteACobrar, "El importe debe ser inferior que cero (0).");
            }

            return valido;
        }
    }
}

