using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CategoriaDAL
    {
        //metodo para cargar listado de categoria
        public static List<clasificaciones> CargarCategorias()
        {
            using (inventarioEntities1 bd = new inventarioEntities1())
            {

                return bd.clasificaciones.ToList();
            }
        }

        //metodo para cargar listado de categorias item opcional
        public static List<clasificaciones> CargarCategoriasOpcional()
        {
            using (inventarioEntities1 bd = new inventarioEntities1())
            {
                List<clasificaciones> list = CargarCategorias();

                list.Insert(0, new clasificaciones() { id_clasificacion = 0, nombre_clasificacion = "Seleccione" });

                return list;
            }
        }
    }
}
