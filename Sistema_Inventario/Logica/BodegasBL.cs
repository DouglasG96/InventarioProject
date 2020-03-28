using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Logica
{
    public class BodegasBL
    {
        public static List<bodegas> cargarBodegas()
        {
            return BodegasDAL.cargarBodegas();
        }
    }
}
