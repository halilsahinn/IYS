#region NAMESPACES
using Microsoft.AspNetCore.Mvc;
#endregion

namespace Invo.izin.Yönetim.Sistemi.Web.MVC.Areas.Secure.Controllers
{
    #region ATTRIBUTES
    [Area("Secure")]

    #endregion

    public class LeaveRequestController : Controller
    {
        #region CTOR
        public LeaveRequestController()
        {

        }

        #endregion

        #region IACTION RESULTS

        public IActionResult Create()
        {

            return View();
        }

        #region INDEX

        #endregion
        public IActionResult Index()
        {
            return View();
        }

        #endregion

    }
}
