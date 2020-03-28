using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace Datos
{
    public class TipoMovimientoDAL
    {
        //metodo para cargar listado de tipos de movimientos
        public static List<tipo_movimiento> cargarTipoMovimientoList()
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                return bd.tipo_movimiento.ToList();
            }
        }

        public static List<tipo_movimiento> cargarTipoMovimiento()
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                List<tipo_movimiento> list = cargarTipoMovimientoList();

                list.Insert(0, new tipo_movimiento() { id_tipo_movimiento = 0, tipo_movimiento1 = "Seleccione" });

                return list;
            }
        }
    }
}
