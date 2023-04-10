#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Web.MVC.Areas.Secure.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
#endregion


namespace Invo.izin.Yönetim.Sistemi.Web.MVC.Areas.Secure.Controllers
{
    #region ATTRIBUTES
    [Area("Secure")]

    #endregion

    public class AccountController : BaseController
    {
        #region CTOR
        public AccountController()
        {

        }

        #endregion

        #region IACTION RESULTS
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult UserList()
        {
            return View();

        }
        #endregion

    }
}
