using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ProductosController : ApiController
    {
        //obtengo productos a vencer entre rango de fechas
        [HttpGet]
        public IHttpActionResult Expiration(string dateInit, string dateEnd)
        {
            DateTime dateI = Convert.ToDateTime(dateInit);
            DateTime dateF = Convert.ToDateTime(dateEnd);
            using (inventarioEntities db = new inventarioEntities())
            {

                var product = (from p in db.productos
                              join m in db.detalles_movimientos on p.id_producto equals m.id_producto                             
                              where m.fecha_vencimiento >= dateI && m.fecha_vencimiento <= dateF
                              select new { Producto = p.nombre, Stock = m.cantidad, Costo_Unitario = m.costo_unitario}).ToList();

                if (product != null)
                    return Ok(product);
                else
                    return NotFound();

            }
        }
        //obtengo productor por proveedor
        [HttpGet]
        public IHttpActionResult Provider(int idProvider)
        {
            using (inventarioEntities db = new inventarioEntities())
            {

                var product = (from p in db.productos
                               join m in db.detalles_movimientos on p.id_producto equals m.id_producto
                               join pr in db.proveedores on p.id_proveedor equals pr.id_proveedor
                               where p.id_producto == idProvider
                               select new { Producto = p.nombre, Proveedor = pr.nombre, Stock = m.cantidad, Costo_Unitario = m.costo_unitario }).ToList();

                if (product != null)
                    return Ok(product);
                else
                    return NotFound();

            }
        }

        //obtengo productor movimientos por bodega
        [HttpGet]
        public IHttpActionResult MovimientoBodega(int idBodega)
        {
            using (inventarioEntities db = new inventarioEntities())
            {

                var product = (from p in db.productos
                               join m in db.detalles_movimientos on p.id_producto equals m.id_producto
                               join b in db.bodegas on m.id_bodega equals b.id_bodega
                               where b.id_bodega == idBodega
                               group p by new { Producto = p.nombre, Bodega = b.nombre_bodega, Stock =  m.cantidad, Costo_Unitario = m.costo_unitario} into g
                               select new { Producto = g.Key.Producto, Bodega = g.Key.Bodega, Stock = g.Key.Stock, Costo_Unitario = g.Key.Costo_Unitario }).ToList();

                if (product != null)
                    return Ok(product);
                else
                    return NotFound();

            }
        }
    }
}
