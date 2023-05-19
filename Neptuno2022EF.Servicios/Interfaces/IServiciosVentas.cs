using Neptuno2022EF.Entidades.Dtos.Ciudad;
using Neptuno2022EF.Entidades.Dtos.DetalleVenta;
using Neptuno2022EF.Entidades.Dtos.Venta;
using Neptuno2022EF.Entidades.Entidades;
using System;
using System.Collections.Generic;

namespace Neptuno2022EF.Servicios.Interfaces
{
    public interface IServiciosVentas
    {
        List<VentaListDto> GetVentas();
        List<VentaListDto> GetVentas(int clienteId);
        List<VentaListDto> Filtrar(Func<Venta, bool> predicado, int cantidad, int pagina);
        int GetCantidad();
        List<VentaListDto> GetVentasPorPagina(int cantidad, int pagina);
        int GetCantidad(Func<Venta, bool> predicado);

        List<DetalleVentaListDto> GetDetalleVenta(int ventaId);
        
        void Guardar(Venta venta);
        
        
        //List<VentaListDto> GetFechas();
        

        
        
    }
}
