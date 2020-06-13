using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ProveedorController : ApiController
    {
        //Metodo para obtener proveedores
        //Servira para llenar Combox
        [HttpGet]
        public IHttpActionResult GetProviders()
        {
            using (inventarioEntities db = new inventarioEntities())
            {

                var provider = (from pr in db.proveedores
                                select new { Id_Proveedor = pr.id_proveedor, Nombre = pr.nombre }).ToList();

                if (provider != null)
                    return Ok(provider);
                else
                    return NotFound();

            }
        }
    }
}
