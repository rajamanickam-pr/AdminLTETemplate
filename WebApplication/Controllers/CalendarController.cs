using System.Web.Mvc;

namespace WebApplication.Controllers
{
    [AllowAnonymous]
    public class CalendarController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}