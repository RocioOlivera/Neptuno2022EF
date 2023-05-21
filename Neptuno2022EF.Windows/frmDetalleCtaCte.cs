using Neptuno2022EF.Entidades.Dtos.Cliente;
using Neptuno2022EF.Entidades.Dtos.CtaCte;
using Neptuno2022EF.Entidades.Dtos.DetalleCtaCte;
using Neptuno2022EF.Entidades.Dtos.DetalleVenta;
using Neptuno2022EF.Entidades.Dtos.Venta;
using Neptuno2022EF.Entidades.Entidades;
using Neptuno2022EF.Servicios.Interfaces;
using Neptuno2022EF.Windows.Helpers;
using Neptuno2022EF.Windows.Helpers.Enum;
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
        private readonly IServiciosCtasCtes _servicio;
        private readonly IServiciosClientes servicios;
        public frmDetalleCtaCte()
        {
            InitializeComponent();
        }

        //List<DetalleCtaCteListDto> lista;
        private ClienteListDto clienteListDto;

        private CtaCteDetalleDto detalleDto;
        public void SetCtaCte(CtaCteDetalleDto ctacteDetalleDto)
        {
            detalleDto = ctacteDetalleDto;
        }

        private void frmDetalleCtaCte_Load(object sender, EventArgs e)
        {
            txtCliente.Text = detalleDto.ctaCte.Cliente;
            
            txtSaldo.Text = detalleDto.ctaCte.Saldo.ToString();
            FormHelper.MostrarDatosEnGrilla<DetalleCtaCteListDto>(dgvDatos, detalleDto.detalleCtaCte );
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnIngresarPago_Click(object sender, EventArgs e)
        {

        }
    }
}
