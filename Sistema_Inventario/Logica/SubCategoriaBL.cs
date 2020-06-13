using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class SubCategoriaBL
    {
        //metodo para cargar listado de sub-categoria
        public static List<sub_clasificaciones> CargarSubCategorias()
        {
            return SubCategoriaDAL.CargarSubCategorias();
        }

        //metodo para cargar listado de sub-categoria item opcional
        public static List<sub_clasificaciones> CargarSubCategoriasOpcional()
        {
            return SubCategoriaDAL.CargarSubCategoriasOpcional();
        }
    }
}
