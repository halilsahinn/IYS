﻿#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Web.MVC.Areas.Secure.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
#endregion

namespace Invo.izin.Yönetim.Sistemi.Web.MVC.Areas.Secure.Controllers
{
    #region ATTRIBUTES
  

    #endregion

    public class LeaveRequestController : BaseController
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
