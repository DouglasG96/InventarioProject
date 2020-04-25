using Entidades;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DetallesMovimientosDAL
    {
        static int idProducto = 0;        
        public static List<detalles_movimientos> cargarDetallesMovimientos()
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                return bd.detalles_movimientos.ToList();
            }
        }

        public static decimal consultarExistenciaAnteriorProducto(String identificadorProducto)
        {
            decimal value = 0;
            try
            {
                using (inventarioEntities bd = new inventarioEntities())
                {
                    idProducto = Convert.ToInt32(identificadorProducto);
                    //Consulto el último registro en la bd del producto
                    value =  Convert.ToDecimal(bd.detalles_movimientos
                               .Where(indice => indice.id_producto == idProducto)
                               .OrderByDescending(indice => indice.id_detalle_movimiento)
                               .Select(indice => indice.existencia_anterior)
                               .First()
                               .ToString());
                }
            }
            catch (Exception e)
            {
                Debug.Write(e.Message);
            }
            return value;
        }

        // QueryMethhod1 returns a query as its value.
        IEnumerable<string> QueryMethod1(ref int[] ints)
        {
            var intsToStrings = from i in ints
                                where i > 4
                                select i.ToString();
            return intsToStrings;
        }

        public static List<productos> cargarProductosBodega(int idBodega)
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                List<productos> lista = new List<productos>();
                try
                {
                    /*
                    bd.Database.Connection.Open();
                    lista = bd.productos    // your starting point - table in the "from" statement
                               .Join(bd.detalles_movimientos, // the source table of the inner join
                                    productos => productos.id_producto,        // Select the primary key (the first part of the "on" clause in an sql "join" statement)
                                    detalles_movimientos => detalles_movimientos.id_producto,   // Select the foreign key (the second part of the "on" clause)
                                    (productos, detalles_movimientos) => new {
                                        id_producto = productos,
                                        nombre = productos.nombre,
                                        id_bodega = detalles_movimientos.id_bodega,
                                        estado = productos.estado }
                               ) // selection
                               .Where(indice => indice.id_bodega == idBodega && indice.estado == 1)
                               .ToList();// where statement
                    var query = from detalles_movimientos in bd.detalles_movimientos
                           join productos in bd.productos on detalles_movimientos.id_producto equals productos.id_producto
                           where detalles_movimientos.id_bodega == idBodega && detalles_movimientos.existencia_total > 0
                           select new objProd { id_producto = productos.id_producto, nombre = productos.nombre };
                    lista = objProdM;
                    */
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
                return lista;
            }
        }
    }
}
