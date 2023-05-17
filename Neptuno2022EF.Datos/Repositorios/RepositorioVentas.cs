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

        public List<VentaListDto> Filtrar(Func<Venta, bool> predicado)
        {
            throw new NotImplementedException();
        }

        public int GetCantidad()
        {
            return _context.Ventas.Count();
        }

        public Venta GetVentaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<VentaListDto> GetVentas()
        {
            return _context.Ventas.Include(v=>v.Cliente).OrderBy(v=>v.FechaVenta).Select(v=>new VentaListDto
             {
                    VentaId=v.VentaId,
                    FechaVenta=v.FechaVenta,
                    Cliente=v.Cliente.Nombre,
                    Total=v.Total,
                    Estado=v.Estado.ToString()
             }).ToList();
        }

        public List<VentaListDto> GetVentasPorPagina(int cantidad, int pagina)
        {
            return _context.Ventas.Include(v => v.Cliente).OrderBy(v => v.ClienteId).Skip(cantidad * (pagina - 1)).Take(cantidad).Select
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
