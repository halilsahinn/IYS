using Microsoft.AspNetCore.Mvc;

namespace Invo.izin.Yönetim.Sistemi.Web.MVC.Areas.Secure.Controllers
{
    [Area("Secure")]
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
