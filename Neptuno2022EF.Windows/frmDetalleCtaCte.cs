using Neptuno2022EF.Entidades.Dtos.CtaCte;
using Neptuno2022EF.Entidades.Dtos.DetalleCtaCte;
using Neptuno2022EF.Entidades.Dtos.DetalleVenta;
using Neptuno2022EF.Entidades.Dtos.Venta;
using Neptuno2022EF.Entidades.Entidades;
using Neptuno2022EF.Windows.Helpers;
using NuevaAppComercial2022.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neptuno2022EF.Windows
{
    public partial class frmDetalleCtaCte : Form
    {
        public frmDetalleCtaCte()
        {
            InitializeComponent();
        }

        List<CtaCteListDto> lista;
        private Cliente cliente;
        //public void SetCtaCte(List<CtaCteListDto> listaMovimientosCtaCte)
        //{
        //    lista= listaMovimientosCtaCte;
        //}
        private CtaCteDetalleDto detalleDto;
        public void SetCtaCte(CtaCteDetalleDto ctacteDetalleDto)
        {
            detalleDto = ctacteDetalleDto;
        }

        //protected override void OnLoad(EventArgs e)
        //{
        //    base.OnLoad(e);
        //    if (lista != null)
        //    {
        //        cliente = lista[0].Cliente;
        //        txtCliente.Text = cliente.Nombre.ToString();
        //        txtDire.Text = cliente.Direccion;
        //        txtCiudad.Text = cliente.Ciudad.ToString();
        //        txtPais.Text = cliente.Pais.ToString();

        //        if (lista.Count > 0)
        //        {
        //            MostrarDatosGrilla(lista);
        //            txtSaldo.Text = lista[lista.Count - 1].Saldo.ToString("c");
        //        }
        //    }
        //}

        //private void MostrarDatosGrilla(List<CtaCteListDto> lista)
        //{
        //    dgvDatos.Rows.Clear();
        //    foreach (var ctaCte in lista)
        //    {
        //        DataGridViewRow r = new DataGridViewRow();
        //        r.CreateCells(dgvDatos);
        //        SetearFila(r, ctaCte);
        //        AgregarFila(r);
        //    }
        //}

        //private void AgregarFila(DataGridViewRow r)
        //{
        //    dgvDatos.Rows.Add(r);
        //}

        //private void SetearFila(DataGridViewRow r, CtaCteListDto ctaCte)
        //{
        //    r.Cells[colFecha.Index].Value = ctaCte.FechaMovimiento;
        //    r.Cells[colMovimiento.Index].Value = ctaCte.Movimiento;
        //    r.Cells[colDebe.Index].Value = ctaCte.Debe;
        //    r.Cells[colHaber.Index].Value = ctaCte.Haber;

        //    r.Tag = ctaCte;

        //}

        private void frmDetalleCtaCte_Load(object sender, EventArgs e)
        {
            txtCliente.Text = detalleDto.ctaCte.Cliente;
            
            txtSaldo.Text = detalleDto.ctaCte.Saldo.ToString();
            FormHelper.MostrarDatosEnGrilla<DetalleCtaCteListDto>(dgvDatos, detalleDto.detalleCtaCte);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
