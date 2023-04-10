#region NAMESPACES
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
#endregion

namespace Invo.izin.Yönetim.Sistemi.WebAPI.Controllers.Base
{
    #region ATTRIBUTES
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    #endregion

    public class BaseController : ControllerBase
    {
        #region FIELDS
         
        //protected IMediator? Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
        //private IMediator? _mediator;

        #endregion

        #region CTOR
        public BaseController()
        {
            
        }
        #endregion

    }

}
