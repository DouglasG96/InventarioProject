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
        public static bodegas CrearBodega(bodegas nuevabodega)
        {
            return BodegaDAL.CrearBodega(nuevabodega);
        }

        public static tipo_bodega_bodegas CrearTipoBodegaBodega(tipo_bodega_bodegas nuevabodegabodega)
        {
            return BodegaDAL.CrearTipoBodegaBodega(nuevabodegabodega);
        }
    }
}

