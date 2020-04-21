using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Logica
{
    public class BodegasBL
    {
        public static List<vw_bodegas> CargarBodegas()
        {
            return BodegaDAL.CargarBodegas();
        }

        public static List<bodegas> CargarBodegasSelector()
        {
            return BodegaDAL.CargarBodegasSelector();
        }

        public static vw_bodegas DetalleBodegas(int id)
        {
            return BodegaDAL.DetalleBodega(id);
        }

        public static List<bodegas> BuscarBodega(string nombre)
        {
            return BodegaDAL.BuscarBodega(nombre);
        }
        public static bodegas ObtenerIdBodega(int id)
        {
            return BodegaDAL.ObtenerIdBodega(id);
        }

        public static bodegas CrearBodega(bodegas nuevabodega)
        {
            return BodegaDAL.CrearBodega(nuevabodega);
        }

        public static tipo_bodega_bodegas CrearTipoBodegaBodega(tipo_bodega_bodegas nuevabodegabodega)
        {
            return BodegaDAL.CrearTipoBodegaBodega(nuevabodegabodega);
        }

        public static bodegas EditarBodega(bodegas bodega)
        {
            return BodegaDAL.EditarBodega(bodega);
        }

        public static int EliminarBodega(int id)
        {
            return BodegaDAL.EliminarBodega(id);
        }
    }
}

