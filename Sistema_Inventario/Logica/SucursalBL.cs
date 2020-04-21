using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Logica
{
    public class SucursalBL
    {
        public static List<vw_sucursal> DetalleSucursales()
        {
            return SucursalDAL.DetalleSucursales();
        }

        public static List<sucursales> CargarSucursales()
        {
            return SucursalDAL.CargarSucursales();
        }

        public static sucursales CrearSucursal(sucursales nuevasucursal)
        {
            return SucursalDAL.CrearSucursal(nuevasucursal);
        }
    }
}
