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

        //Metodo para buscar  categoria por id
        public static clasificacion DetalleCategoria(int id)
        {
            return CategoriaDAL.DetalleCategoria(id);
        }


        //Metodo para buscar  categoria por nombre
        public static List<clasificacion> BuscarCategoria(string nombre)
        {
            return CategoriaDAL.BuscarCategoria(nombre);
        }

        public static clasificacion CrearCategoria(clasificacion categoria)
        {
            return CategoriaDAL.CrearCategoria(categoria);
        }

        public static clasificacion EditarCategoria(clasificacion categoria)
        {
            return CategoriaDAL.EditarCategoria(categoria);
        }

        public static int EliminarCategoria(int id)
        {
            return CategoriaDAL.EliminarCategoria(id);
        }
    }
}
