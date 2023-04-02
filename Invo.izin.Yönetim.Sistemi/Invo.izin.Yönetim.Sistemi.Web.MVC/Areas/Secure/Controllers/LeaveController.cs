#region NAMESPACES
using Microsoft.AspNetCore.Mvc;
#endregion

namespace Invo.izin.Yönetim.Sistemi.Web.MVC.Areas.Secure.Controllers
{
    #region ATTRIBUTES
    [Area("Secure")]

    #endregion

    public class LeaveController : Controller
    {
        #region CTOR
        public LeaveController()
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
