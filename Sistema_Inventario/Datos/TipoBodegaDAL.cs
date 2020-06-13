using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class TipoBodegaDAL
    {
        public static List<tipo_bodega> CargarTipoBodega()
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                var todatipobodega = bd.tipo_bodega;

                return todatipobodega.ToList();
            }
        }

        public static  tipo_bodega CrearTipoBodega(tipo_bodega tipobodega)
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                tipo_bodega tipob = new tipo_bodega();
                tipob.tipo = tipobodega.tipo;
                tipob.estado = tipobodega.estado;
                bd.tipo_bodega.Add(tipob);
                bd.SaveChanges();

            }

            return tipobodega;
        }

        public tipo_bodega Crear_Tipo(tipo_bodega tipobode)
        {
            throw new NotImplementedException();
        }


        public static int EliminarTipoBodega(int id)
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                //var prod = (from p in bd.productos
                //              where p.id_producto == id
                //              select p).FirstOrDefault();

                var tb = bd.tipo_bodega.First(x => x.id_tipo_bodega == id);//obtenemos registro por medio de id
                tb.estado = 0;
                bd.Entry(tb).State = System.Data.Entity.EntityState.Modified;
                bd.SaveChanges();
            }
            return id;
        }

        public static tipo_bodega ObtenerIdTipoBodega(int id)
        {
            tipo_bodega tipobod = new tipo_bodega();
            using (inventarioEntities bd = new inventarioEntities())
            {
                var tipobo = bd.tipo_bodega.First(x => x.id_tipo_bodega == id);

                tipobo.id_tipo_bodega = tipobo.id_tipo_bodega;
                tipobo.tipo = tipobo.tipo;
                tipobo.estado = tipobo.estado;

                return tipobo;
            }
        }
        public static tipo_bodega EditarTipoBodega(tipo_bodega tipobodegat)
        {
            using (inventarioEntities bd = new inventarioEntities())
            {

                var bg = bd.tipo_bodega.First(x => x.id_tipo_bodega == tipobodegat.id_tipo_bodega);//obtenemos registro por medio de id

                bg.id_tipo_bodega = tipobodegat.id_tipo_bodega;
                bg.tipo = tipobodegat.tipo;
                bg.estado = tipobodegat.estado;

                bd.Entry(bg).State = System.Data.Entity.EntityState.Modified;
                bd.SaveChanges();
            }
            return tipobodegat;
        }


        public static List<tipo_bodega> BuscarTipoBodega(string nombre)
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                //var producto = (from p in bd.productos
                //              where p.nombre == nombre
                //              select p).ToList();
                var tipobodega = bd.tipo_bodega.Where(x => x.tipo.StartsWith(nombre)).ToList();

                return tipobodega;
            }
        }
    }
}
