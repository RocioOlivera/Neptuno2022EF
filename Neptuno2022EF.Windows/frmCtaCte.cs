using Microsoft.Win32;
using Neptuno2022EF.Entidades.Dtos.Ciudad;
using Neptuno2022EF.Entidades.Dtos.CtaCte;
using Neptuno2022EF.Entidades.Dtos.DetalleCtaCte;
using Neptuno2022EF.Entidades.Dtos.Venta;
using Neptuno2022EF.Entidades.Entidades;
using Neptuno2022EF.Servicios.Interfaces;
using Neptuno2022EF.Windows.Helpers;
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

namespace Neptuno2022EF.Windows
{
    public partial class frmCtaCte : Form
    {
        private readonly IServiciosCtasCtes _servicio;
        public frmCtaCte(IServiciosCtasCtes servicio)
        {
            InitializeComponent();
            _servicio = servicio;
        }
        CtaCteListDto ctaCte = new CtaCteListDto();
        private void frmCtaCte_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

 

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private List<ResumenCtaCteDto> lista;
        private void MostrarDatosEnGrilla()
        {
            FormHelper.MostrarDatosEnGrilla<ResumenCtaCteDto>(dgvDatos, lista);
        }

        private void RecargarGrilla()
        {
            try
            {
                lista = _servicio.GetCtasCtes();
                MostrarDatosEnGrilla();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tsbDetalle_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            var ctaDto = (ResumenCtaCteDto)r.Tag;
            try
            {
                var detalle = _servicio.GetDetalleCtaCte(ctaDto.ClienteId);
                var ctaDetalleDto = new CtaCteDetalleDto()
                {
                    ctaCte = ctaCte,
                    detalleCtaCte = detalle

                };
                frmDetalleCtaCte frm = new frmDetalleCtaCte() { Text = "Detalle de la Cuenta Corriente" };
                frm.SetCtaCte(ctaDetalleDto);
                frm.ShowDialog(this);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
