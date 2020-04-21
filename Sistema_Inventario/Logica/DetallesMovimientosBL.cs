using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Logica
{
    public class DetallesMovimientosBL
    {
        public static detalles_movimientos consultarDetallesMovimientosProducto(String idProducto)
        {
            return DetallesMovimientosDAL.consultarDetallesMovimientosProducto(idProducto);
        }
    }
}
