using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class SubCategoriaDAL
    {
        //metodo para cargar listado de sub-categoria
        public static List<sub_clasificaciones> CargarSubCategorias()
        {
            using (inventarioEntities bd = new inventarioEntities())
            {

                return bd.sub_clasificaciones.ToList();
            }
        }

        //metodo para cargar listado de sub-categoria item opcional
        public static List<sub_clasificaciones> CargarSubCategoriasOpcional()
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                List<sub_clasificaciones> list = CargarSubCategorias();

                list.Insert(0, new sub_clasificaciones() { id_sub_clasificacion = 0, sub_clasificacion = "Seleccione" });

                return list;
            }
        }
    }
}
