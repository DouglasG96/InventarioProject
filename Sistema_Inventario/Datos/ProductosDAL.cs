using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ProductosDAL
    {
        //metodo para cargar listado de productos
        public static List<vw_producto> CargarProductos()
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                return bd.vw_producto.ToList();
            }
        }

        //Metodo para buscar  producto por nombre
        public static vw_producto DetalleProducto(int id)
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                var producto = bd.vw_producto.First(x => x.id_producto == id);

                return producto;
            }
        }

        public static productos ObtenerIdProducto(int id)
        {
            productos prod = new productos();
            using (inventarioEntities bd = new inventarioEntities())
            {
                var producto = bd.productos.First(x => x.id_producto == id);

                prod.id_producto = producto.id_producto;
                prod.nombre = producto.nombre;
                prod.codigo = producto.codigo;
                prod.descripcion = producto.descripcion;
                prod.id_vigencia_promedio = producto.id_vigencia_promedio;
                prod.id_clasificacion = producto.id_clasificacion;
                prod.id_proveedor = producto.id_proveedor;

                return prod;
            }
        }

        //Metodo para buscar  producto por nombre
        public static List<productos> BuscarProducto(string nombre)
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                var producto = (from p in bd.productos
                              where p.nombre == nombre
                              select p).ToList();

                return producto;
            }
        }

        public static void CrearProducto(string nombre, string codigo, string descripcion, int id_vigencia, int id_clasificacion, int id_proveedor)
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                productos prod = new productos();
                prod.nombre = nombre;
                prod.codigo = codigo;
                prod.descripcion = descripcion;
                prod.id_vigencia_promedio = id_vigencia;
                prod.id_clasificacion = id_clasificacion;
                prod.id_proveedor = id_proveedor;
                prod.fecha_creacioon = DateTime.Now.Date;
                prod.hora_creacion = DateTime.Now.TimeOfDay;
                bd.productos.Add(prod);
                bd.SaveChanges();
            }
        }

        public static void EditarProducto(int id, string nombre, string codigo, string descripcion, int id_vigencia, int id_clasificacion, int id_proveedor)
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                //var prod = (from p in bd.productos
                //              where p.id_producto == id
                //              select p).FirstOrDefault();

                var prod = bd.productos.First(x => x.id_producto == id);//obtenemos registro por medio de id

                prod.id_producto = id;
                prod.nombre = nombre;
                prod.codigo = codigo;
                prod.descripcion = descripcion;
                prod.id_vigencia_promedio = id_vigencia;
                prod.id_clasificacion = id_clasificacion;
                prod.id_proveedor = id_proveedor;
                bd.Entry(prod).State = System.Data.Entity.EntityState.Modified;
                bd.SaveChanges();
            }
        }

        public static void EliminarProducto(int id)
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                //var prod = (from p in bd.productos
                //              where p.id_producto == id
                //              select p).FirstOrDefault();

                var prod = bd.productos.First(x => x.id_producto == id);//obtenemos registro por medio de id

                bd.productos.Remove(prod);
                bd.SaveChanges();
            }
        }
    }
}
