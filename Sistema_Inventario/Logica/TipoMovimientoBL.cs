using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Logica
{
    public class TipoMovimientoBL
    {
        public static List<vw_tipo_movimiento> CargarTipoMovimientoSelector()
        {
            return TipoMovimientoDAL.CargarTipoMovimientoSelector();
        }
    }
}
