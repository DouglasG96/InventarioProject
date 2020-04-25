using Entidades;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DetallesMovimientosDAL
    {
        static int idProducto = 0;        
        public static List<detalles_movimientos> cargarDetallesMovimientos()
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                return bd.detalles_movimientos.ToList();
            }
        }


        public static decimal consultarExistenciaAnteriorProducto(String identificadorProducto)
        {
            decimal value = 0;
            try
            {
                using (inventarioEntities bd = new inventarioEntities())
                {
                    idProducto = Convert.ToInt32(identificadorProducto);
                    //Consulto el último registro en la bd del producto
                    value =  Convert.ToDecimal(bd.detalles_movimientos
                               .Where(indice => indice.id_producto == idProducto)
                               .OrderByDescending(indice => indice.id_detalle_movimiento)
                               .Select(indice => indice.existencia_anterior)
                               .First()
                               .ToString());
                }
            }
            catch (Exception e)
            {
                Debug.Write(e.Message);
            }
            return value;
        }
    }
}
