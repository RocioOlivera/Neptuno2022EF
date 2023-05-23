using Neptuno2022EF.Datos.Interfaces;
using Neptuno2022EF.Entidades.Dtos.CtaCte;
using Neptuno2022EF.Entidades.Dtos.DetalleCtaCte;
using Neptuno2022EF.Entidades.Dtos.DetalleVenta;
using Neptuno2022EF.Entidades.Dtos.Venta;
using Neptuno2022EF.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
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

        public List<ResumenCtaCteDto> GetCtasCtes()
        {
            var lista=_context.CtaCtes.Include(c => c.Cliente)
                .GroupBy(c=>c.Cliente.Nombre)
                .ToList();
            var registros=new List<ResumenCtaCteDto>();
            foreach (var grupo in lista)
            {
                var itemCta = new ResumenCtaCteDto
                {
                    ClienteId = grupo.First().ClienteId,
                    NombreCliente = grupo.Key,
                    Saldo = grupo.Sum(x => x.Debe - x.Haber)
                };
                registros.Add(itemCta);
            }
            return registros;
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

        public List<DetalleCtaCteListDto> GetDetalleCtaCte(int clienteId)
        {
            return _context.CtaCtes.Include(c => c.Cliente)
                .Where(c => c.ClienteId == clienteId)
                .Select(c => new DetalleCtaCteListDto()
                {
                    CtaCteId = c.CtaCteId,
                    FechaMovimiento = c.FechaMovimiento,
                    Movimiento=c.Movimiento,
                    Debe = c.Debe,
                    Haber = c.Haber,
                    Saldo = c.Saldo,
                    Cliente = c.Cliente.Nombre

                }).ToList();
        }

        public void Agregar(CtaCte ctaCte)
        {
            _context.CtaCtes.Add(ctaCte);
        }


    }
}
