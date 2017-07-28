using System.Web.Mvc;

namespace WebApplication.Controllers
{
    [AllowAnonymous]
    public class DocumentationController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}