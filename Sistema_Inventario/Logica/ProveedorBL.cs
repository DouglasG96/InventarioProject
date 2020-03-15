using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ProveedorBL
    {
        //metodo para cargar listado de proveedores
        public static List<proveedores> CargarProveedores()
        {
            return ProveedorDAL.CargarProveedores();
        }

        //metodo para cargar listado de proveedores item opcional
        public static List<proveedores> CargarProveedoresOpcional()
        {
            return ProveedorDAL.CargarProveedoresOpcional();
        }
    }
}
