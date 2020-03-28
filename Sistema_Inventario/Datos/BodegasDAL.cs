using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace Datos
{
    public class BodegasDAL
    {
        public static List<bodegas> cargarBodegasList()
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                return bd.bodegas.ToList();
            }
        }

        public static List<bodegas> cargarBodegas()
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                List<bodegas> list = cargarBodegasList();

                list.Insert(0, new bodegas() { id_bodega = 0, nombre_bodega = "Seleccione" });

                return list;
            }
        }
    }
}
