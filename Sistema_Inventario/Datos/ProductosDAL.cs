using Entidades;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ProductosDAL
    {
        static int idProducto = 0;

        //metodo para cargar listado de productos
        public static List<vw_producto> CargarProductos()
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                return bd.vw_producto.ToList();
            }
        }

        public static List<productos> cargarProductosSelector()
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                List<productos> list = cargarProductosOpcional();

                list.Insert(0, new productos() { id_producto = 0, nombre = "Seleccione" });

                return list;
            }
        }

        public static List<productos> cargarProductosOpcional()
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                List<productos> listaProductos = new List<productos>();
                try
                {
                    bd.Database.Connection.Open();

                    listaProductos = bd.productos.Where(indice => indice.estado == 1).ToList();
                }
                catch (Exception e)
                {
                    // Imprime error en la consola
                    Debug.Write(e);
                }
                finally
                {
                    bd.Database.Connection.Close();
                }
                return listaProductos;
            }
        }

        //Metodo para buscar  producto por id
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
                prod.id_sub_clasificacion = producto.id_sub_clasificacion;
                prod.id_proveedor = producto.id_proveedor;

                return prod;
            }
        }

        //Metodo para buscar  producto por nombre
        public static List<productos> BuscarProducto(string nombre)
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                //var producto = (from p in bd.productos
                //              where p.nombre == nombre
                //              select p).ToList();
                var producto = bd.productos.Where(x => x.nombre.StartsWith(nombre)).ToList();

                return producto;
            }
        }

        public static productos CrearProducto(productos producto)
        {
            using (inventarioEntities bd = new inventarioEntities())
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
                prod.estado = 1;
                bd.productos.Add(prod);
                bd.SaveChanges();
            }

            return producto;
        }

        public static productos EditarProducto(productos producto)
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
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
            using (inventarioEntities bd = new inventarioEntities())
            {
                var prod = bd.productos.First(x => x.id_producto == id);//obtenemos registro por medio de id
                prod.estado = 0;
                bd.Entry(prod).State = System.Data.Entity.EntityState.Modified;
                bd.SaveChanges();
            }
            return id;
        }

        public static productos consultarDatosProducto(String identificadorProducto)
        {
            productos objProductos = new productos();
            try
            {
                using (inventarioEntities bd = new inventarioEntities())
                {
                    idProducto = Convert.ToInt32(identificadorProducto);
                    objProductos = bd.productos.First(indice => indice.id_producto == idProducto && indice.estado == 1);
                }
            }
            catch (Exception e)
            {
                Debug.Write(e.Message);
            }
            return objProductos;
        }
    }
}
