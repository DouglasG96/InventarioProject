using System.Web.Mvc;

namespace WebAppInventario.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AnotherLink()
        {
            return View("Index");
        }

        public ActionResult Login()
        {

            return View("Login");

        }
        [HttpPost]
        public ActionResult Login(string user, string pass)
        {
            if (user.Trim() == "admin" && pass.Trim() == "admin")
            {
                Session["user"] = user;
                return RedirectToAction("Index", "Home");
            }

            else
            {
                ViewBag.Error = "Datos Incorrectos...!";

            }
            return View();

        }

        public ActionResult Logoff()
        {
            Session["user"] = null;
            return RedirectToAction("Login", "Home");
        }
    }
}
