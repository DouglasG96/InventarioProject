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
    }
}
