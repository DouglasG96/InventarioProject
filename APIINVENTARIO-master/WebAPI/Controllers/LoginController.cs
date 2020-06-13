using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class LoginController : ApiController
    {
        inventarioEntities db = new inventarioEntities();

        [HttpGet]
        public IHttpActionResult Login(string user, string pass)
        {

            using (inventarioEntities db = new inventarioEntities())
            {
                var login = db.usuarios.Where(x => x.usuario == user && x.clave == pass).FirstOrDefault();
                if (login != null)
                    return Ok(new usuarios() {nombre_completo = login.nombre_completo, id_rol = login.id_rol, id_usuario = login.id_usuario, usuario = login.usuario, clave = login.clave, dui = login.dui, estado = login.estado, estado_sesion = login.estado_sesion, fecha_ultimo_ingreso = login.fecha_ultimo_ingreso, hora_ultimo_ingreso = login.hora_ultimo_ingreso } );
                else
                    return NotFound();
            }
        }
    }
}
