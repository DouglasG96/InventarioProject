using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class TipoMovimientoDAL
    {
        //metodo para cargar listado de tipo Proveedor
        public static List<vw_tipo_movimiento> CargarTipoMovimientoOpcional()
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                return bd.vw_tipo_movimiento.Where(indice => indice.estado == 1).ToList();
            }
        }

        public static List<vw_tipo_movimiento> CargarTipoMovimientoSelector()
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                List<vw_tipo_movimiento> list = CargarTipoMovimientoOpcional();

                list.Insert(0, new vw_tipo_movimiento() { id_tipo_movimiento = 0, tipo_movimiento = "Seleccione" });

                return list;
            }
        }
    }
}
