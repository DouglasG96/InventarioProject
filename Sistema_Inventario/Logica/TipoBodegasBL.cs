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

        public static tipo_bodega CrearTipoBodega(tipo_bodega tipobode)
        {
            return TipoBodegaDAL.CrearTipoBodega(tipobode);
        }
    }
}
