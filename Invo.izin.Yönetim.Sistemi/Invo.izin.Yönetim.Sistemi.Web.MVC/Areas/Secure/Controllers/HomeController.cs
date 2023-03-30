#region NAMESPACES
using Microsoft.AspNetCore.Mvc;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Web.MVC.Areas.Secure.Controllers
{
    [Area("Secure")]
    public class HomeController : Controller
    {
        #region CTOR
        public HomeController()
        {

        }
        #endregion

        #region IACTION RESULTS
        public IActionResult Index()
        {
            return View();
        }

        #endregion
    }
}
