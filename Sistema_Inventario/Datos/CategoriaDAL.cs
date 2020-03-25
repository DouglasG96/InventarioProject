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
        public static List<clasificacion> CargarCategorias()
        {
            using (inventarioEntities bd = new inventarioEntities())
            {

                return bd.clasificacion.ToList();
            }
        }

        //metodo para cargar listado de categorias item opcional
        public static List<clasificacion> CargarCategoriasOpcional()
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                List<clasificacion> list = CargarCategorias();

                list.Insert(0, new clasificacion() { id_clasificacion = 0, nombre_clasificacion = "Seleccione" });

                return list;
            }
        }
    }
}
