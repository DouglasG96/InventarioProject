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
        public static List<vw_proveedor> CargarProveedores()
        {
            using (inventarioEntities bd = new inventarioEntities())
            {

                return bd.vw_proveedor.ToList();
            }
        }

        //metodo para cargar listado de proveedores item opcional
        public static List<vw_proveedor> CargarProveedoresOpcional()
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                List<vw_proveedor> list = CargarProveedores();

                list.Insert(0, new vw_proveedor() { id_proveedor = 0, nombre = "Seleccione"});

                return list;
            }
        }

        //Metodo para buscar  proveedor por id
        public static proveedores DetalleProveedor(int id)
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                var proveedor = bd.proveedores.First(x => x.id_proveedor == id);

                return proveedor;
            }
        }

        //Metodo para buscar  proveedor por nombre
        public static List<vw_proveedor> BuscarProveedor(string nombre)
        {
            using (inventarioEntities bd = new inventarioEntities())
            {

                var proveedor = bd.vw_proveedor.Where(x => x.nombre.StartsWith(nombre)).ToList();

                return proveedor;
            }
        }

        public static proveedores CrearProveedor(proveedores proveedor)
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                proveedores prov = new proveedores();
                prov.nombre = proveedor.nombre;
                prov.direccion = proveedor.direccion;
                prov.nit = proveedor.nit;
                prov.nrc = proveedor.nrc;
                prov.correo = proveedor.correo;
                prov.razon_social = proveedor.razon_social;
                prov.id_tipo_proveedor = proveedor.id_tipo_proveedor;
                prov.estado = 1;
                bd.proveedores.Add(prov);
                bd.SaveChanges();
            }

            return proveedor;
        }

        public static proveedores EditarProveedor(proveedores proveedor)
        {
            using (inventarioEntities bd = new inventarioEntities())
            {

                var prov = bd.proveedores.First(x => x.id_proveedor == proveedor.id_proveedor);//obtenemos registro por medio de id
                prov.nombre = proveedor.nombre;
                prov.direccion = proveedor.direccion;
                prov.nit = proveedor.nit;
                prov.nrc = proveedor.nrc;
                prov.correo = proveedor.correo;
                prov.razon_social = proveedor.razon_social;
                prov.id_proveedor = proveedor.id_proveedor;
                bd.Entry(prov).State = System.Data.Entity.EntityState.Modified;
                bd.SaveChanges();
            }
            return proveedor;
        }

        public static int EliminarProveedor(int id)
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                var prov = bd.proveedores.First(x => x.id_proveedor == id);//obtenemos registro por medio de id
                prov.estado = 0;
                bd.Entry(prov).State = System.Data.Entity.EntityState.Modified;
                bd.SaveChanges();
            }
            return id;
        }
    }
}
