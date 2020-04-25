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
        public static decimal consultarExistenciaAnteriorProducto(String idProducto)
        {
            return DetallesMovimientosDAL.consultarExistenciaAnteriorProducto(idProducto);
        }
    }
}
