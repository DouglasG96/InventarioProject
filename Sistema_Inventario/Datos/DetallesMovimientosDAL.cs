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


        public static detalles_movimientos consultarDetallesMovimientosProducto(String identificadorProducto)
        {
            detalles_movimientos objDetallesMovimientos = new detalles_movimientos();
            try
            {
                using (inventarioEntities bd = new inventarioEntities())
                {
                    idProducto = Convert.ToInt32(identificadorProducto);
                    objDetallesMovimientos = bd.detalles_movimientos.First(indice => indice.id_producto == idProducto && indice.estado == 1);
                }
            }
            catch (Exception e)
            {
                Debug.Write(e.Message);
            }
            return objDetallesMovimientos;
        }
    }
}
