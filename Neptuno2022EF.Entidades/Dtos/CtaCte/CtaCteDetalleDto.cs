using Neptuno2022EF.Entidades.Dtos.DetalleCtaCte;
using Neptuno2022EF.Entidades.Dtos.DetalleVenta;
using Neptuno2022EF.Entidades.Dtos.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptuno2022EF.Entidades.Dtos.CtaCte
{
    public class CtaCteDetalleDto
    {
        public CtaCteListDto ctaCte { get; set; }
        public List<DetalleCtaCteListDto> detalleCtaCte { get; set; }
    }
}
