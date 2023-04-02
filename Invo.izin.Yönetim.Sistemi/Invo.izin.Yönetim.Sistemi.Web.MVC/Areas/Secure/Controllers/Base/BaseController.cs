#region NAMESPACES
using MediatR;
using Microsoft.AspNetCore.Mvc;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Web.MVC.Areas.Secure.Controllers.Base
{
    public class BaseController : Controller
    {
        #region FIELDS
        protected IMediator? Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
        private IMediator? _mediator;

        #endregion

        #region CTOR
        public BaseController()
        {

        }
        #endregion
 
    }
}
