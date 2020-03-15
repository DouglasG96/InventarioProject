using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ProveedorDAL
    {
        //metodo para cargar listado de proveedores
        public static List<proveedores> CargarProveedores()
        {
            using (inventarioEntities1 bd = new inventarioEntities1())
            {

                return bd.proveedores.ToList();
            }
        }

        //metodo para cargar listado de proveedores item opcional
        public static List<proveedores> CargarProveedoresOpcional()
        {
            using (inventarioEntities1 bd = new inventarioEntities1())
            {
                List<proveedores> list = CargarProveedores();

                list.Insert(0, new proveedores() { id_proveedor = 0, nombre = "Seleccione"});

                return list;
            }
        }
    }
}
