#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Web.MVC.Areas.Secure.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Web.MVC.Areas.Secure.Controllers
{ 
    public class HomeController : BaseController
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
