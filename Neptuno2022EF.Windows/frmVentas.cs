using Neptuno2022EF.Entidades.Dtos.Ciudad;
using Neptuno2022EF.Entidades.Dtos.Cliente;
using Neptuno2022EF.Entidades.Dtos.Venta;
using Neptuno2022EF.Entidades.Entidades;
using Neptuno2022EF.Ioc;
using Neptuno2022EF.Servicios.Interfaces;
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
    public partial class frmVentas : Form
    {
        private readonly IServiciosVentas _servicio;
        private List<VentaListDto> lista;

        private int cantidadPorPagina =10;
        private int registros;
        private int paginas;
        private int paginaActual = 1;

        private bool filtroOn = false;
        public frmVentas(IServiciosVentas servicio)
        {
            InitializeComponent();
            _servicio = servicio;
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            RecargarGrilla();

        }
        
        private void MostrarDatosEnGrilla()
        {
            FormHelper.MostrarDatosEnGrilla<VentaListDto>(dgvDatos, lista);
            lblRegistros.Text = registros.ToString();
            lblPaginaActual.Text = paginaActual.ToString();
            lblPaginas.Text = paginas.ToString();
        }


        private void tsbDetalle_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            var ventaDto = (VentaListDto)r.Tag;
            try
            {
                var detalle = _servicio.GetDetalleVenta(ventaDto.VentaId);
                var ventaDetalleDto = new VentaDetalleDto()
                {
                    venta = ventaDto,
                    detalleVenta = detalle
                };
                frmDetalleVenta frm = new frmDetalleVenta() { Text = "Detalle de la Venta" };
                frm.SetVenta(ventaDetalleDto);
                frm.ShowDialog(this);
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmVentaAE frm = new frmVentaAE(DI.Create<IServiciosClientes>(),DI.Create<IServiciosProductos>()) { Text = "Nueva Venta" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                var venta = frm.GetVenta();
                _servicio.Guardar(venta);
                MessageBox.Show("Venta guardada", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                //var r=GridHelper.ConstruirFila(dgvDatos);
                //GridHelper.SetearFila(r, dgvDatos);
                //GridHelper.AgregarFila(dgvDatos, r);
                RecargarGrilla();
                venta = null;
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void RecargarGrilla()
        {
            try
            {
                if (filtroOn)
                {
                    registros = _servicio.GetCantidad(predicado);
                }
                else
                {
                    registros = _servicio.GetCantidad();

                }
                
                paginas = CalculosHelper.CalcularCantidadPaginas(registros, cantidadPorPagina);
                paginaActual = 1;
                MostrarPaginado();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void MostrarPaginado()
        {
            if (filtroOn)
            {
                lista = _servicio.Filtrar(predicado, cantidadPorPagina, paginaActual);
            }
            else
            {
                lista = _servicio.GetVentasPorPagina(cantidadPorPagina, paginaActual);

            }
            MostrarDatosEnGrilla();

        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            paginaActual = 1;
            MostrarPaginado();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (paginaActual == 1)
            {
                return;
            }
            paginaActual--;
            MostrarPaginado();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (paginaActual == paginas)
            {
                return;
            }
            paginaActual++;
            MostrarPaginado();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            paginaActual = paginas;
            MostrarPaginado();
        }

        Func<Venta, bool> predicado;
        private void tsbFiltrar_Click(object sender, EventArgs e)
        {
            frmSeleccionarClienteFecha frm = new frmSeleccionarClienteFecha() { Text = "Seleccionar Cliente y/o Fecha" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) { return; }
            try
            {
                var clienteSeleccionado = frm.GetCliente();
                predicado = c => c.ClienteId == clienteSeleccionado.ClienteId;
                //lista = _servicio.Filtrar(predicado);
                //lista = _servicio.GetVentas(clienteSeleccionado.ClienteId);
                //MostrarDatosEnGrilla();
                filtroOn = true;
                RecargarGrilla();
                tsbFiltrar.BackColor = Color.Orange;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            filtroOn = false;
            RecargarGrilla();
            tsbFiltrar.BackColor = Color.White;
        }
    }
}
