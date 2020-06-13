using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppInventario.Models;

namespace WebAppInventario.Controllers
{
    public class ReportsController : Controller
    {
        inventarioEntities db = new inventarioEntities();
        // GET: Reports
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProductsToExpire(string InitDate, string EndDate)
        {
            if (InitDate == null || InitDate == "")
                    InitDate = "1900-01-01";
            if (EndDate == null || EndDate == "")
                    EndDate = "2900-01-01";
            var dataReport = db.sp_consulta_productos_por_vencer(InitDate, EndDate).ToList();
            var list = new { data = dataReport };
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ProductCode()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProductCode(string code)
        {
            if (code == null || code == "")
                code = null;
            var dataReport = db.sp_consulta_producto(code).ToList();
            var list = new { data = dataReport };
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public ActionResult KardexTypeM()
        {
            return View();
        }

        [HttpPost]
        public ActionResult KardexTypeM(string code)
        {
            if (code == null || code == "")
                code = null;
            var dataReport = db.sp_consulta_producto(code).ToList();
            var list = new { data = dataReport };
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}