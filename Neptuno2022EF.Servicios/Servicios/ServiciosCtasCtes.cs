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
        public List<CtaCteListDto> GetCtaCte()
        {
            try
            {
                return _repositorio.GetCtaCte();
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

        public List<DetalleCtaCteListDto> GetDetalleCtaCte(int ctaCteId)
        {
            try
            {
                return _repositorio.GetDetalleCtaCte(ctaCteId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<DetalleCtaCteListDto> GetDetalleVenta(int ctaCteId)
        {
            try
            {
                return _repositorio.GetDetalleCtaCte(ctaCteId);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
