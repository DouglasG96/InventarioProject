using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class VigenciaBL
    {
        //metodo para cargar listado de dias
        public static List<vigencia_promedio> CargarVigencias()
        {
            return VigenciaDAL.CargarVigencias();
        }
    }
}
