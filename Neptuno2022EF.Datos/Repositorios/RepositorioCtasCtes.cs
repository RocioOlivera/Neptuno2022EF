using Neptuno2022EF.Datos.Interfaces;
using Neptuno2022EF.Entidades.Dtos.CtaCte;
using Neptuno2022EF.Entidades.Dtos.DetalleCtaCte;
using Neptuno2022EF.Entidades.Dtos.DetalleVenta;
using Neptuno2022EF.Entidades.Dtos.Venta;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptuno2022EF.Datos.Repositorios
{
    public class RepositorioCtasCtes:IRepositorioCtasCtes
    {
        private readonly NeptunoDbContext _context;

        public RepositorioCtasCtes(NeptunoDbContext context)
        {
            _context = context;
        }

        public List<CtaCteListDto> GetCtaCte()
        {
            return _context.CtaCtes.Include(c => c.Cliente).Select(c => new CtaCteListDto
            {
                CtaCteId=c.CtaCteId,
                FechaMovimiento=c.FechaMovimiento,
                Movimiento=c.Movimiento,
                Debe=c.Debe,
                Haber=c.Haber,
                Saldo=c.Saldo,
                Cliente=c.Cliente.Nombre
            }).AsNoTracking().ToList();
        }

        public List<CtaCteListDto> GetCtaCte(int clienteId)
        {
            return _context.CtaCtes.Include(c => c.Cliente).Where(c=>c.ClienteId==clienteId).Select(c => new CtaCteListDto
            {
                CtaCteId = c.CtaCteId,
                FechaMovimiento = c.FechaMovimiento,
                Movimiento = c.Movimiento,
                Debe = c.Debe,
                Haber = c.Haber,
                Saldo = c.Saldo,
                Cliente = c.Cliente.Nombre
            }).AsNoTracking().ToList();
        }

        public List<DetalleCtaCteListDto> GetDetalleCtaCte(int ctaCteId)
        {
            return _context.CtaCtes.Include(c => c.Cliente)
                .Where(c => c.CtaCteId == ctaCteId)
                .Select(c => new DetalleCtaCteListDto()
                {
                    CtaCteId = c.CtaCteId,
                    FechaMovimiento = c.FechaMovimiento,
                    Debe = c.Debe,
                    Haber = c.Haber,
                    Saldo = c.Saldo,
                    Cliente = c.Cliente.Nombre

                }).ToList();
        }
    }
}
