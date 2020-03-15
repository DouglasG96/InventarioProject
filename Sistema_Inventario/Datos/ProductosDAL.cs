using Entidades;
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
            using (inventarioEntities1 bd = new inventarioEntities1())
            {
                return bd.vw_producto.ToList();
            }
        }

        //Metodo para buscar  producto por nombre
        public static vw_producto DetalleProducto(int id)
        {
            using (inventarioEntities1 bd = new inventarioEntities1())
            {
                var producto = bd.vw_producto.First(x => x.id_producto == id);

                return producto;
            }
        }

        public static productos ObtenerIdProducto(int id)
        {
            productos prod = new productos();
            using (inventarioEntities1 bd = new inventarioEntities1())
            {
                var producto = bd.productos.First(x => x.id_producto == id);

                prod.id_producto = producto.id_producto;
                prod.nombre = producto.nombre;
                prod.codigo = producto.codigo;
                prod.descripcion = producto.descripcion;
                prod.id_vigencia_promedio = producto.id_vigencia_promedio;
                prod.id_sub_clasificacion = producto.id_sub_clasificacion;
                prod.id_proveedor = producto.id_proveedor;

                return prod;
            }
        }

        //Metodo para buscar  producto por nombre
        public static List<productos> BuscarProducto(string nombre)
        {
            using (inventarioEntities1 bd = new inventarioEntities1())
            {
                var producto = (from p in bd.productos
                              where p.nombre == nombre
                              select p).ToList();

                return producto;
            }
        }

        public static productos CrearProducto(productos producto)
        {
            using (inventarioEntities1 bd = new inventarioEntities1())
            {
                productos prod = new productos();
                prod.nombre = producto.nombre;
                prod.codigo = producto.codigo;
                prod.descripcion = producto.descripcion;
                prod.id_vigencia_promedio = producto.id_vigencia_promedio;
                prod.id_sub_clasificacion = producto.id_sub_clasificacion;
                prod.id_proveedor = producto.id_proveedor;
                //prod.fecha_creacion = DateTime.Now.Date;
                prod.fecha_creacion = producto.fecha_creacion;
                //prod.hora_creacion = DateTime.Now.TimeOfDay;
                prod.hora_creacion = producto.hora_creacion;
                bd.productos.Add(prod);
                bd.SaveChanges();
            }

            return producto;
        }

        public static productos EditarProducto(productos producto)
        {
            using (inventarioEntities1 bd = new inventarioEntities1())
            {
                //var prod = (from p in bd.productos
                //              where p.id_producto == id
                //              select p).FirstOrDefault();

                var prod = bd.productos.First(x => x.id_producto == producto.id_producto);//obtenemos registro por medio de id

                prod.id_producto = producto.id_producto;
                prod.nombre = producto.nombre;
                prod.codigo = producto.codigo;
                prod.descripcion = producto.descripcion;
                prod.id_vigencia_promedio = producto.id_vigencia_promedio;
                prod.id_sub_clasificacion = producto.id_sub_clasificacion;
                prod.id_proveedor = producto.id_proveedor;
                bd.Entry(prod).State = System.Data.Entity.EntityState.Modified;
                bd.SaveChanges();
            }
            return producto;
        }

        public static int EliminarProducto(int id)
        {
            using (inventarioEntities1 bd = new inventarioEntities1())
            {
                //var prod = (from p in bd.productos
                //              where p.id_producto == id
                //              select p).FirstOrDefault();

                var prod = bd.productos.First(x => x.id_producto == id);//obtenemos registro por medio de id

                bd.productos.Remove(prod);
                bd.SaveChanges();
            }
            return id;
        }
    }
}
