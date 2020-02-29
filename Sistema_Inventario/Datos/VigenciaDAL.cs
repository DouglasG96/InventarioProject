using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class VigenciaDAL
    {
        //metodo para cargar listado de dias
        public static List<vigencia_promedio> CargarVigencias()
        {
            using (inventarioEntities bd = new inventarioEntities())
            {

                return bd.vigencia_promedio.ToList();
            }
        }
    }
}
