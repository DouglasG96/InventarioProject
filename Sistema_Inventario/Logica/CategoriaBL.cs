using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CategoriaBL
    {
        public static List<clasificacion> CargarCategorias()
        {
            return CategoriaDAL.CargarCategorias();
        }

        //metodo para cargar listado de categorias item opcional
        public static List<clasificacion> CargarCategoriasOpcional()
        {
            return CategoriaDAL.CargarCategoriasOpcional();
        }
    }
}
