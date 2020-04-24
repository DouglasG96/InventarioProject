using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class MovimientosBL
    {
        static movimientos objMovimientos;

        //metodo para cargar listado de productos
        public static List<vw_movimientos> cargarMovimientos()
        {
            return MovimientosDAL.cargarMovimientos();
        }

        public static int consultarNumeroMovimientos()
        {
            return MovimientosDAL.consultarNumeroMovimientos();
        }

        public static double calcularCostoTotalConIva(double costo, double cantidad,double costoTotalConIva)
        {
            return (costoTotalConIva + (costo * cantidad));
        }

        public static double calcularCostoTotalSinIva(double costoTotalConIva)
        {
            return (costoTotalConIva / 1.13);
        }

        public static movimientos crearMovimiento(movimientos objMovimiento)
        {
            objMovimientos = objMovimiento;
            return MovimientosDAL.crearMovimiento(objMovimientos);
        }

        public static detalles_movimientos crearDetalleMovimientos(detalles_movimientos detallesMovimientos)
        {
            return MovimientosDAL.crearDetalleMovimientos(objMovimientos , detallesMovimientos);
        }
    }
}
