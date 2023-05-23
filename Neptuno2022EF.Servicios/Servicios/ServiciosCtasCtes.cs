using Neptuno2022EF.Datos.Interfaces;
using Neptuno2022EF.Datos;
using Neptuno2022EF.Entidades.Dtos.CtaCte;
using Neptuno2022EF.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neptuno2022EF.Entidades.Dtos.DetalleCtaCte;
using Neptuno2022EF.Entidades.Entidades;
using Neptuno2022EF.Entidades.Dtos.DetalleVenta;
using System.Transactions;
using Neptuno2022EF.Entidades.Enums;
using System.Data.SqlClient;

namespace Neptuno2022EF.Servicios.Servicios
{
    public class ServiciosCtasCtes : IServiciosCtasCtes
    {
        private readonly IRepositorioCtasCtes _repositorio;
        private readonly IRepositorioClientes _repoCliente;
        
        private readonly IUnitOfWork _unitOfWork;

        public ServiciosCtasCtes(IRepositorioCtasCtes repositorio, IRepositorioClientes repoClientes, IUnitOfWork unitOfWork)
        {
            _repositorio = repositorio;
            _repoCliente = repoClientes;
            _unitOfWork = unitOfWork;
        }
        public List<ResumenCtaCteDto> GetCtasCtes()
        {
            try
            {
                return _repositorio.GetCtasCtes();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<CtaCteListDto> GetCtaCte(int clienteId)
        {
            try
            {
                return _repositorio.GetCtaCte(clienteId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<DetalleCtaCteListDto> GetDetalleCtaCte(int clienteId)
        {
            try
            {
                return _repositorio.GetDetalleCtaCte(clienteId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(CtaCte ctaCte)
        {
            try
            {
                using (var transaction = new TransactionScope())
                {
                    var ctaCteGuardar = new CtaCte()
                    {
                        FechaMovimiento = ctaCte.FechaMovimiento,
                        Movimiento = ctaCte.Movimiento,
                        Debe = ctaCte.Debe,
                        Haber = ctaCte.Haber,
                        Saldo = ctaCte.Saldo,
                        Cliente = ctaCte.Cliente
                    };
                    _repositorio.Agregar(ctaCte);
                    _unitOfWork.SaveChanges();
                    transaction.Complete();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public void Pagar(CtaCte ctaCte, FormaPago forma, decimal importe)
        {
            try
            {
            _repositorio.Agregar(ctaCte);

            }

            catch (Exception)
            {
                throw;
            }

        }

    }
}
