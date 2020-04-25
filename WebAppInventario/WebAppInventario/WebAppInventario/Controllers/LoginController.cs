using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppInventario.Models;

namespace WebAppInventario.Controllers
{
    public class LoginController : Controller
    {
        inventarioEntities db = new inventarioEntities();

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Access(string user, string pass)
        {
            using (inventarioEntities db = new inventarioEntities())
            {
                var login = db.usuarios.Where(x => x.usuario == user && x.clave == pass).FirstOrDefault();
                if (login != null)
                {
                    Session["user"] = login.nombre_completo;
                    return RedirectToAction("Index", "Reports");
                }

                else
                {
                    ViewBag.Error = "Datos Incorrectos...!";
                    return RedirectToAction("Index", "Login");
                }
            }
        }

        public ActionResult Logoff()
        {
            Session["user"] = null;
            return RedirectToAction("Index", "Login");
        }
    }
}