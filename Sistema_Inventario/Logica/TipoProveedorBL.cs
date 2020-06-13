using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Logica
{
    public class TipoProveedorBL
    {
        public static List<tipo_proveedor> CargarTipoProveedor()
        {
            return TipoProveedorDAL.CargarTipoProveedor();
        }

        //metodo para cargar listado de tipo proveedor item opcional
        public static List<tipo_proveedor> CargarTipoProveedoOpcional()
        {
            return TipoProveedorDAL.CargarTipoProveedorOpcional();
        }
    }
}
