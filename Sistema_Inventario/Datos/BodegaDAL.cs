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
        public static List<vw_bodegas> CargarBodegas()
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                return bd.vw_bodegas.ToList();
            }
        }

        public static List<bodegas> CargarBodegasSelector()
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                List<bodegas> list = CargarBodegasOpcional();

                list.Insert(0, new bodegas() { id_bodega = 0, nombre_bodega = "Seleccione" });

                return list;
            }
        }

        public static List<bodegas> CargarBodegasOpcional()
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                return bd.bodegas.ToList();
            }
        }

        public static List<bodegas> BuscarBodega(string nombre)
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                //var producto = (from p in bd.productos
                //              where p.nombre == nombre
                //              select p).ToList();
                var bodega = bd.bodegas.Where(x => x.nombre_bodega.StartsWith(nombre)).ToList();

                return bodega;
            }
        }

        public static vw_bodegas DetalleBodega(int id)
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                var bodega = bd.vw_bodegas.First(x => x.id_bodega == id);

                return bodega;
            }
        }

        public static bodegas ObtenerIdBodega(int id)
        {
            bodegas bod = new bodegas();
            using (inventarioEntities bd = new inventarioEntities())
            {
                var bodega = bd.bodegas.First(x => x.id_bodega == id);

                bodega.id_bodega = bodega.id_bodega;
                bodega.nombre_bodega = bodega.nombre_bodega;
                bodega.id_sucursal = bodega.id_sucursal;
                bodega.id_tipo_bodega = bodega.id_tipo_bodega;
                bodega.estado = bodega.estado;

                return bodega;
            }
        }

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
        public static bodegas EditarBodega(bodegas bodegat)
        {
            using (inventarioEntities bd = new inventarioEntities())
            {

                var bg = bd.bodegas.First(x => x.id_bodega == bodegat.id_bodega);//obtenemos registro por medio de id

                bg.id_bodega = bodegat.id_bodega;
                bg.nombre_bodega = bodegat.nombre_bodega;
                bg.id_sucursal = bodegat.id_sucursal;
                bg.id_tipo_bodega = bodegat.id_tipo_bodega;

                bd.Entry(bg).State = System.Data.Entity.EntityState.Modified;
                bd.SaveChanges();
            }
            return bodegat;
        }

        public static int EliminarBodega(int id)
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                //var prod = (from p in bd.productos
                //              where p.id_producto == id
                //              select p).FirstOrDefault();

                var bod = bd.bodegas.First(x => x.id_bodega == id);//obtenemos registro por medio de id
                bod.estado = 0;
                bd.Entry(bod).State = System.Data.Entity.EntityState.Modified;
                bd.SaveChanges();
            }
            return id;
        }
    }
}
