using Neptuno2022EF.Entidades.Dtos.Ciudad;
using Neptuno2022EF.Entidades.Dtos.Venta;
using Neptuno2022EF.Entidades.Entidades;
using System;
using System.Collections.Generic;

namespace Neptuno2022EF.Datos.Interfaces
{
    public interface IRepositorioVentas
    {
        List<VentaListDto> GetVentas();
        void Agregar(Venta venta);
        Venta GetVentaPorId(int id);
        List<VentaListDto> GetVentas(int clientesId);
        
        List<VentaListDto> Filtrar(Func<Venta, bool> predicado, int cantidad, int pagina);
        //List<VentaListDto> Filtrar(Func<Venta, bool> predicado);

        int GetCantidad();
        List<VentaListDto> GetVentasPorPagina(int cantidad, int pagina);
        
        int GetCantidad(Func<Venta, bool> predicado);
        //List<VentaListDto> GetFechas();
    }
}
