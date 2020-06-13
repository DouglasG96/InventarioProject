using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class BodegaController : ApiController
    {
        //Metodo para obtener Bodegas
        //Servira para llenar Combox
        [HttpGet]
        public IHttpActionResult GetBodegas()
        {
            using (inventarioEntities db = new inventarioEntities())
            {

                var bodega = (from b in db.bodegas
                                select new { Id_Bodega = b.id_bodega, Nombre = b.nombre_bodega }).ToList();

                if (bodega != null)
                    return Ok(bodega);
                else
                    return NotFound();

            }
        }
    }
}
