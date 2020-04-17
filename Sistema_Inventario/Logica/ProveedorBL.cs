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
        public static List<vw_proveedor> CargarProveedores()
        {
            return ProveedorDAL.CargarProveedores();
        }

        //metodo para cargar listado de proveedores item opcional
        public static List<vw_proveedor> CargarProveedoresOpcional()
        {
            return ProveedorDAL.CargarProveedoresOpcional();
        }

        //Metodo para buscar  proveedor por id
        public static proveedores DetalleProveedor(int id)
        {
            return ProveedorDAL.DetalleProveedor(id);
        }


        //Metodo para buscar  proveedor por nombre
        public static List<vw_proveedor> BuscarProveedor(string nombre)
        {
            return ProveedorDAL.BuscarProveedor(nombre);
        }

        public static proveedores CrearProveedor(proveedores proveedor)
        {
            return ProveedorDAL.CrearProveedor(proveedor);
        }

        public static proveedores EditarProveedor(proveedores proveedor)
        {
            return ProveedorDAL.EditarProveedor(proveedor);
        }

        public static int EliminarProveedor(int id)
        {
            return ProveedorDAL.EliminarProveedor(id);
        }
    }
}
