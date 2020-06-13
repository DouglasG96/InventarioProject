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
                if(objMovimiento.id_proveedor == 0)
                {
                    objMovimiento.id_proveedor = null;
                }
                bd.movimientos.Add(objMovimiento);
                bd.SaveChanges();
            }
            return objMovimiento;
        }

        public static detalles_movimientos crearDetalleMovimientos(detalles_movimientos detallesMovimientos, movimientos objMovimientos)
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                tipo_bodega_bodegas tipoBodegaBodegas = new tipo_bodega_bodegas();
                tipoMovimiento = Convert.ToInt32(objMovimientos.id_tipo_movimiento);
                idBodega = Convert.ToInt32(detallesMovimientos.id_bodega);
                cantidadMovimiento = Convert.ToDouble(detallesMovimientos.cantidad);
                tipo_bodega_bodegas Tipo_Bodega_Bodegas = BodegaDAL.cargarDatosBodega(tipoBodegaBodegas, idBodega);
                cantidadCapacidadMaxima = Convert.ToDouble(Tipo_Bodega_Bodegas.capacidad_maxima);
                cantidadCapacidadActual = Convert.ToDouble(Tipo_Bodega_Bodegas.capacidad_actual);
                switch (tipoMovimiento)
                {
                    case 1:
                        if(actualizarExistenciaBodega(idBodega,cantidadMovimiento,cantidadCapacidadMaxima,cantidadCapacidadActual))
                        {
                            bd.detalles_movimientos.Add(detallesMovimientos);
                            bd.SaveChanges();
                        }
                        else
                        {
                            detallesMovimientos = null;
                        }
                        break;
                    case 2:
                        cantidadCapacidadActual = (cantidadCapacidadActual - cantidadMovimiento);
                        if(cantidadCapacidadActual == 0)
                        {
                            detallesMovimientos = null;
                        }
                        else
                        {
                            var bg = bd.tipo_bodega_bodegas.First(indice => indice.id_bodega == idBodega);
                            if (bg != null)
                            {
                                bg.capacidad_actual = Convert.ToDecimal(cantidadCapacidadActual);

                                bd.Entry(bg).State = System.Data.Entity.EntityState.Modified;
                                bd.SaveChanges();

                            }
                            bd.detalles_movimientos.Add(detallesMovimientos);
                            bd.SaveChanges();
                        }
                        break;
                    case 3:
                        
                        bd.detalles_movimientos.Add(detallesMovimientos);
                        bd.SaveChanges();
                        
                        break;
                    case 4:
                        cantidadCapacidadActual = (cantidadCapacidadActual - cantidadMovimiento);
                        if (cantidadCapacidadActual == 0)
                        {
                            detallesMovimientos = null;
                        }
                        else
                        {
                            var bg = bd.tipo_bodega_bodegas.First(indice => indice.id_bodega == idBodega);
                            if (bg != null)
                            {
                                bg.capacidad_actual = Convert.ToDecimal(cantidadCapacidadActual);

                                bd.Entry(bg).State = System.Data.Entity.EntityState.Modified;
                                bd.SaveChanges();

                            }
                            bd.detalles_movimientos.Add(detallesMovimientos);
                            bd.SaveChanges();
                        }
                        break;
                }
            }
            return detallesMovimientos;
        } 
        
        public static bool actualizarExistenciaBodega(int idBodega, double cantidadMovimiento, double capacidadMaxima, double cantidadCapacidadActual)
        {
            bool bandera = false;
            if ((cantidadMovimiento + cantidadCapacidadActual) >= cantidadCapacidadMaxima)
            {
                bandera = false;
            }
            else
            {
                cantidadCapacidadActual = (cantidadCapacidadActual + cantidadMovimiento);
                using (inventarioEntities bd = new inventarioEntities())
                {
                    var bg = bd.tipo_bodega_bodegas.First(indice => indice.id_bodega == idBodega);
                    if(bg != null)
                    {
                        bg.capacidad_actual = Convert.ToDecimal(cantidadCapacidadActual);

                        bd.Entry(bg).State = System.Data.Entity.EntityState.Modified;
                        bd.SaveChanges();
                        bandera = true;
                    }
                }
            }
            return bandera;
        }
    }
}
