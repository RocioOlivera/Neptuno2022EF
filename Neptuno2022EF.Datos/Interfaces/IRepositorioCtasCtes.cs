using Neptuno2022EF.Entidades.Dtos.CtaCte;
using Neptuno2022EF.Entidades.Dtos.DetalleCtaCte;
using Neptuno2022EF.Entidades.Dtos.DetalleVenta;
using Neptuno2022EF.Entidades.Dtos.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptuno2022EF.Datos.Interfaces
{
    public interface IRepositorioCtasCtes
    {
        List<ResumenCtaCteDto> GetCtasCtes();
        List<CtaCteListDto> GetCtaCte(int clienteId);

        List<DetalleCtaCteListDto> GetDetalleCtaCte(int clienteId);
    }
}
