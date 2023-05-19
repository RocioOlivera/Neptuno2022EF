using Neptuno2022EF.Datos.Interfaces;
using Neptuno2022EF.Entidades.Dtos.Ciudad;
using Neptuno2022EF.Entidades.Dtos.Venta;
using Neptuno2022EF.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Neptuno2022EF.Datos.Repositorios
{
    public class RepositorioVentas : IRepositorioVentas
    {
        private readonly NeptunoDbContext _context;

        public RepositorioVentas(NeptunoDbContext context)
        {
            _context = context;
        }

        public void Agregar(Venta venta)
        {
            _context.Ventas.Add(venta);
        }

        public List<VentaListDto> Filtrar(Func<Venta, bool> predicado, int cantidad, int pagina)
        {
            return _context.Ventas.Include(v => v.Cliente)
             .Where(predicado)
              .OrderBy(v => v.FechaVenta)
              .Skip(cantidad * (pagina - 1))
              .Take(cantidad)
              .Select(v => new VentaListDto
              {
                    VentaId = v.VentaId,
                    FechaVenta = v.FechaVenta,
                    Cliente = v.Cliente.Nombre,
                    Total=v.Total,
                    Estado=v.Estado.ToString()
              }).ToList();
        }

        public int GetCantidad()
        {
            return _context.Ventas.Count();
        }
        public int GetCantidad(Func<Venta, bool> predicado)
        {
            return _context.Ventas.Count(predicado);
        }
        //public List<VentaListDto> GetFechas()
        //{
        //    return _context.Ventas.OrderBy(v => v.FechaVenta).Select(v => new VentaListDto
        //    {
        //        VentaId = v.VentaId,
        //        FechaVenta = v.FechaVenta,
        //        Cliente = v.Cliente.Nombre,
        //        Total = v.Total,
        //        Estado = v.Estado.ToString()
        //    }).ToList();
        //}

        public Venta GetVentaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<VentaListDto> GetVentas()
        {
            return _context.Ventas.Include(v=>v.Cliente).Select(v=>new VentaListDto
             {
                    VentaId=v.VentaId,
                    FechaVenta=v.FechaVenta,
                    Cliente=v.Cliente.Nombre,
                    Total=v.Total,
                    Estado=v.Estado.ToString()
             }).AsNoTracking().ToList();
        }

        public List<VentaListDto> GetVentas(int clienteId)
        {
            try
            {
                return _context.Ventas.Include(v => v.Cliente).
                    Where(v=>v.ClienteId==clienteId).Select(v => new VentaListDto
                {
                    VentaId = v.VentaId,
                    FechaVenta = v.FechaVenta,
                    Cliente = v.Cliente.Nombre,
                    Total = v.Total,
                    Estado = v.Estado.ToString()
                }).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<VentaListDto> GetVentasPorPagina(int cantidad, int pagina)
        {
            return _context.Ventas.Include(v => v.Cliente).OrderBy(v => v.ClienteId).
                Skip(cantidad * (pagina - 1)).Take(cantidad).Select
                (v => new VentaListDto
            {
                    VentaId = v.VentaId,
                    FechaVenta = v.FechaVenta,
                    Cliente = v.Cliente.Nombre,
                    Total=v.Total,
                    Estado=v.Estado.ToString()
            }).ToList();
        }
    }
}
