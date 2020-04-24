using Entidades;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class MovimientosDAL
    {
        static tipo_bodega_bodegas Tipo_Bodega_Bodegas;
        static int tipoMovimiento = 0;
        static int idBodega = 0;
        static double cantidadMovimiento = 0;
        static double cantidadCapacidadMaxima = 0.0000;
        static double cantidadCapacidadActual = 0.0000;

        //metodo para cargar listado de productos
        public static List<vw_movimientos> cargarMovimientos()
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                return bd.vw_movimientos.ToList();
            }
        }

        public static int consultarNumeroMovimientos()
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                return bd.movimientos.Count() + 1;
            }
        }
        public static movimientos crearMovimiento(movimientos objMovimiento)
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                bd.movimientos.Add(objMovimiento);
                bd.SaveChanges();
            }
            return objMovimiento;
        }

        public static detalles_movimientos crearDetalleMovimientos(movimientos objMovimientos, detalles_movimientos detallesMovimientos)
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                tipoMovimiento = Convert.ToInt32(objMovimientos.tipo_movimiento);
                idBodega = Convert.ToInt32(detallesMovimientos.id_bodega);
                cantidadMovimiento = Convert.ToDouble(detallesMovimientos.cantidad);
                Tipo_Bodega_Bodegas = BodegaDAL.cargarDatosBodega(Tipo_Bodega_Bodegas,idBodega);
                cantidadCapacidadMaxima = Convert.ToDouble(Tipo_Bodega_Bodegas.capacidad_maxima);
                cantidadCapacidadActual = Convert.ToDouble(Tipo_Bodega_Bodegas.capacidad_actual);
                switch (tipoMovimiento)
                {
                    case 1:
                        if(aumentarExistenciaBodega(idBodega,cantidadMovimiento,cantidadCapacidadMaxima,cantidadCapacidadActual))
                        {
                            bd.detalles_movimientos.Add(detallesMovimientos);
                            bd.SaveChanges();
                        }
                        else
                        {
                            return detallesMovimientos = null;
                        }
                        break;
                    case 3:
                        bd.detalles_movimientos.Add(detallesMovimientos);
                        bd.SaveChanges();
                        break;
                }
            }
            return detallesMovimientos;
        } 
        
        public static bool aumentarExistenciaBodega(int idBodega, double cantidadMovimiento, double capacidadMaxima, double cantidadCapacidadActual)
        {
            if ((cantidadMovimiento + cantidadCapacidadActual) >= cantidadCapacidadMaxima)
            {
                return false;
            }
            else
            {
                cantidadCapacidadActual = (cantidadCapacidadActual + cantidadMovimiento);
                using (inventarioEntities bd = new inventarioEntities())
                {
                    var bg = bd.tipo_bodega_bodegas.First(indice => indice.id_bodega == idBodega);

                    bg.capacidad_actual = Convert.ToDecimal(cantidadCapacidadActual);

                    bd.Entry(bg).State = System.Data.Entity.EntityState.Modified;
                    bd.SaveChanges();
                }
                return true;
            }
        }
    }
}
