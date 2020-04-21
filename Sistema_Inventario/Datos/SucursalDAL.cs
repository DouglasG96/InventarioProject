using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class SucursalDAL
    {
        public static List<vw_sucursal> DetalleSucursales()
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                return bd.vw_sucursal.ToList();
            }
        }
        public static List<sucursales> CargarSucursales()
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                var todasucursales = bd.sucursales;

                return todasucursales.ToList();
            }
        }

        public static sucursales CrearSucursal(sucursales sucursal)
        {

            using (inventarioEntities bd = new inventarioEntities())
            {
                sucursales nuevasucursal = new sucursales();
                nuevasucursal.sucursal = sucursal.sucursal;
                nuevasucursal.estado = sucursal.estado;
                bd.sucursales.Add(nuevasucursal);
                bd.SaveChanges();


            }

            return sucursal;
        }
    }
}
