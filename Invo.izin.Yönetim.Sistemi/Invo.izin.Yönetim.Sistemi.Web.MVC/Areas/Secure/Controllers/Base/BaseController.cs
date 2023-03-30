using Microsoft.AspNetCore.Mvc;

namespace Invo.izin.Yönetim.Sistemi.Web.MVC.Areas.Secure.Controllers.Base
{
    public class BaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
