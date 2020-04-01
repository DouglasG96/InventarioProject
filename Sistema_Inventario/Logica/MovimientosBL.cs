using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class MovimientosBL
    {
        //metodo para cargar listado de productos
        public static List<vw_movimientos> cargarMovimientos()
        {
            return MovimientosDAL.cargarMovimientos();
        }

        /*
        //Metodo para buscar  producto por id
        public static vw_producto DetalleProducto(int id)
        {
            return ProductosDAL.DetalleProducto(id);
        }

        public static productos ObtenerIdProducto(int id)
        {
            return ProductosDAL.ObtenerIdProducto(id);
        }

        //Metodo para buscar  producto por nombre
        public static List<productos> BuscarProducto(string nombre)
        {
            return ProductosDAL.BuscarProducto(nombre);
        }

        public static productos CrearProducto(productos producto)
        {
            return ProductosDAL.CrearProducto(producto);
        }

        public static productos EditarProducto(productos producto)
        {
            return ProductosDAL.EditarProducto(producto);
        }

        public static int EliminarProducto(int id)
        {
            return ProductosDAL.EliminarProducto(id);
        }
        */
    }
}
