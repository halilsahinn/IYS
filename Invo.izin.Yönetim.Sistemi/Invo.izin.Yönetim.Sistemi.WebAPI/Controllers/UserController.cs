#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Application.DTOs.Employee;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.LeaveRequest;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.User;
using Invo.izin.Yönetim.Sistemi.Application.Feautures.Employee.Commands.Create;
using Invo.izin.Yönetim.Sistemi.Application.Feautures.User.Queries;
using Invo.izin.Yönetim.Sistemi.Application.Responses;
using Invo.izin.Yönetim.Sistemi.WebAPI.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;
#endregion

namespace Invo.izin.Yönetim.Sistemi.WebAPI.Controllers
{
    public class UserController : BaseController
    {
        #region FIELDS
        private readonly IMediator _mediator;


        #endregion

        #region CTOR
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        #endregion

        #region ACTION RESULTS

        #region INDEX

        // GET: api/<UserController>
        [HttpGet("UserSelectList")]
        public async Task<ActionResult<List<SelectUserDto>>> Get()
        {
            var userSelectList = await _mediator.Send(new GetUserListQuery());
            return Ok(userSelectList);
        
        }

        #endregion



        #endregion


    }
}
