﻿using Neptuno2022EF.Entidades.Dtos.Ciudad;
using Neptuno2022EF.Entidades.Dtos.Cliente;
using Neptuno2022EF.Entidades.Dtos.CtaCte;
using Neptuno2022EF.Entidades.Dtos.DetalleCtaCte;
using Neptuno2022EF.Entidades.Dtos.DetalleVenta;
using Neptuno2022EF.Entidades.Dtos.Producto;
using Neptuno2022EF.Entidades.Dtos.Proveedor;
using Neptuno2022EF.Entidades.Dtos.Venta;
using Neptuno2022EF.Entidades.Entidades;
using Neptuno2022EF.Windows.Classes;
using System;
using System.Windows.Forms;

namespace Neptuno2022EF.Windows.Helpers
{
    public static class GridHelper
    {
        public static void LimpiarGrilla(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

        }
        public static DataGridViewRow ConstruirFila(DataGridView dataGrid)
        {
            var r = new DataGridViewRow();
            r.CreateCells(dataGrid);
            return r;
        }

        public static void AgregarFila(DataGridView dataGrid, DataGridViewRow r)
        {
            dataGrid.Rows.Add(r);
        }

        public static void SetearFila(DataGridViewRow r, Object obj)
        {
            switch (obj)
            {
                case Pais p:
                    r.Cells[0].Value = p.NombrePais;

                    break;
                case Categoria c:
                    r.Cells[0].Value = c.NombreCategoria;
                    r.Cells[1].Value = c.Descripcion;

                    break;
                case CiudadListDto ciudadDto:
                    r.Cells[0].Value = ciudadDto.NombrePais;
                    r.Cells[1].Value = ciudadDto.NombreCiudad;

                    break;
                case ClienteListDto clienteDto:
                    r.Cells[0].Value = clienteDto.NombreCliente;
                    r.Cells[1].Value = clienteDto.Pais;
                    r.Cells[2].Value = clienteDto.Ciudad;
                    break;
                case ProveedorListDto proveedorDto:
                    r.Cells[0].Value = proveedorDto.NombreProveedor;
                    r.Cells[1].Value = proveedorDto.Pais;
                    r.Cells[2].Value = proveedorDto.Ciudad;
                    break;
                case VentaListDto ventaDto:
                    r.Cells[0].Value = ventaDto.VentaId;
                    r.Cells[1].Value = ventaDto.FechaVenta.ToShortDateString();
                    r.Cells[2].Value = ventaDto.Cliente;
                    r.Cells[3].Value = ventaDto.Total;
                    r.Cells[4].Value = ventaDto.Estado;
                    break;

                case ProductoListDto producto:
                    r.Cells[0].Value = producto.NombreProducto;
                    r.Cells[1].Value = producto.Categoria;
                    r.Cells[2].Value = producto.PrecioUnitario;
                    r.Cells[3].Value = producto.UnidadesDisponibles;
                    r.Cells[4].Value = producto.Suspendido;
                    break;

                case ItemCarrito detalle:
                    r.Cells[0].Value = detalle.Descripcion;
                    r.Cells[1].Value = detalle.Cantidad;
                    r.Cells[2].Value = detalle.Precio;
                    r.Cells[3].Value = detalle.Subtotal;
                    break;
                case DetalleVentaListDto detalle:
                    r.Cells[0].Value = detalle.Producto;
                    r.Cells[1].Value = detalle.Cantidad;
                    r.Cells[2].Value = detalle.PrecioUnitario;
                    r.Cells[3].Value = detalle.Subtotal;
                    break;
                case ResumenCtaCteDto ctaCte:
                    r.Cells[0].Value = ctaCte.NombreCliente;
                    r.Cells[1].Value = ctaCte.Saldo;
                    break;
                case DetalleCtaCteListDto detalleCta:
                    r.Cells[0].Value = detalleCta.FechaMovimiento;
                    r.Cells[1].Value = detalleCta.Movimiento;
                    r.Cells[2].Value = detalleCta.Debe;
                    r.Cells[3].Value = detalleCta.Haber;
                    break;
            }

            r.Tag = obj;

        }

        public static void BorrarFila(DataGridView dataGridView, DataGridViewRow r)
        {
            dataGridView.Rows.Remove(r);
        }

    }
}
