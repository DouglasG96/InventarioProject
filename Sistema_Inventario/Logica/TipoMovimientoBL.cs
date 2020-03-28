using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Logica
{
    public class TipoMovimientoBL
    {
        public static List<tipo_movimiento> cargarTipoMovimiento()
        {
            return TipoMovimientoDAL.cargarTipoMovimiento();
        }
    }
}
