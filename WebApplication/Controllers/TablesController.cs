using System.Web.Mvc;

namespace WebApplication.Controllers
{
    [AllowAnonymous]
    public class TablesController : Controller
    {
        public ActionResult Simple()
        {
            return View();
        }

        public ActionResult Data()
        {
            return View();
        }
    }
}