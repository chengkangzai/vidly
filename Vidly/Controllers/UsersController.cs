using System.Web.Mvc;

namespace Vidly.Controllers
{
    public class UsersController : Controller
    {
        // GET
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}