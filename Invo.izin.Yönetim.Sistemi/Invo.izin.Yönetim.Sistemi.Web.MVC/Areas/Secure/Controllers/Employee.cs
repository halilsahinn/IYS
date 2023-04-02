#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Web.MVC.Areas.Secure.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
#endregion

namespace Invo.izin.Yönetim.Sistemi.Web.MVC.Areas.Secure.Controllers
{
    
    #region ATTRIBUTES
    [Area("Secure")]
    #endregion

    public class Employee : BaseController
    {
        #region CTOR
        public Employee()
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
