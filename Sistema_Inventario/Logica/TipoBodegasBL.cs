using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
   public class TipoBodegasBL
    {
        public static List<tipo_bodega> CargarTipoBodega()
        {
            return TipoBodegaDAL.CargarTipoBodega();
        }

        public static tipo_bodega CrearTipoBodega(tipo_bodega tipobode)
        {
            return TipoBodegaDAL.CrearTipoBodega(tipobode);
        }

        public static int EliminarTipoBodega(int id)
        {
            return TipoBodegaDAL.EliminarTipoBodega(id);
        }

        public static tipo_bodega EditarTipoBodega(tipo_bodega tipobodegat)
        {
            return TipoBodegaDAL.EditarTipoBodega(tipobodegat);
        }

        public static tipo_bodega ObtenerIdTipoBodega(int id)
        {
            return TipoBodegaDAL.ObtenerIdTipoBodega(id);
        }

        public static List<tipo_bodega> BuscarTipoBodega(string nombre)
        {
            return TipoBodegaDAL.BuscarTipoBodega(nombre);
        }
    }
}
