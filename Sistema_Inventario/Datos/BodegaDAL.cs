using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Datos
{
    public class BodegaDAL
    {
        public static bodegas CrearBodega(bodegas bodegas)
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                bodegas nuevabodega = new bodegas();
                nuevabodega.nombre_bodega = bodegas.nombre_bodega;
                nuevabodega.id_sucursal = bodegas.id_sucursal;
                nuevabodega.id_tipo_bodega = bodegas.id_tipo_bodega;
                nuevabodega.estado = bodegas.estado;
                bd.bodegas.Add(nuevabodega);
                bd.SaveChanges();


            }

            return bodegas;
        }

        public static tipo_bodega_bodegas CrearTipoBodegaBodega(tipo_bodega_bodegas tipobodegasbodegas)
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                tipo_bodega_bodegas nuevabodegabodega = new tipo_bodega_bodegas();
                nuevabodegabodega.id_tipo_bodega = tipobodegasbodegas.id_tipo_bodega;
                nuevabodegabodega.id_bodega = tipobodegasbodegas.id_bodega;
                nuevabodegabodega.temperatura_promedio = tipobodegasbodegas.temperatura_promedio;
                nuevabodegabodega.capacidad_maxima = tipobodegasbodegas.capacidad_maxima;
                nuevabodegabodega.capacidad_actual = tipobodegasbodegas.capacidad_actual;
                bd.tipo_bodega_bodegas.Add(nuevabodegabodega);
                bd.SaveChanges();


            }

            return tipobodegasbodegas;
        }
        /*public static List<bodegas> BuscarMaximo()
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                var LastRecord = (from c in bd.bodegas
                                  select c).Max();

                return LastRecord;
            }

           
        }*/
    }
}
