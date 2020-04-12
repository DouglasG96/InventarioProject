using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class TipoProveedorDAL
    {
        //metodo para cargar listado de tipo Proveedor
        public static List<tipo_proveedor> CargarTipoProveedor()
        {
            using (inventarioEntities bd = new inventarioEntities())
            {

                return bd.tipo_proveedor.Where(x => x.estado == 1).ToList();
            }
        }

        //metodo para cargar listado de tipo Proveedor item opcional
        public static List<tipo_proveedor> CargarTipoProveedorOpcional()
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                List<tipo_proveedor> list = CargarTipoProveedor();

                list.Insert(0, new tipo_proveedor() { id_tipo_proveedor = 0, tipo_proveedor1 = "Seleccione" });

                return list;
            }
        }
    }
}
