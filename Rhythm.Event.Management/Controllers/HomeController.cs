using System.Web.Mvc;

namespace Rhythm.Event.WebAPI.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
