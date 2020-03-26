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
        public static sucursales CrearSucursal(sucursales nuevasucursal)
        {
            return SucursalDAL.CrearSucursal(nuevasucursal);
        }
    }
}
