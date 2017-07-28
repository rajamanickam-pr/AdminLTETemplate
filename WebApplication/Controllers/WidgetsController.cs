using System.Web.Mvc;

namespace WebApplication.Controllers
{
    [AllowAnonymous]
    public class WidgetsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}