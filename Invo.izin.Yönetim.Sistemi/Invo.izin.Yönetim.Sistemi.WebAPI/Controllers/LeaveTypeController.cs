#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Application.DTOs.LeaveType;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.User;
using Invo.izin.Yönetim.Sistemi.Application.Feautures.LeaveTYpe;
using Invo.izin.Yönetim.Sistemi.Application.Feautures.User.Queries;
using Invo.izin.Yönetim.Sistemi.WebAPI.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;
#endregion


namespace Invo.izin.Yönetim.Sistemi.WebAPI.Controllers
{
    public class LeaveTypeController : BaseController
    {
        #region FIELDS
        private readonly IMediator _mediator;

        #endregion

        #region CTOR

        public LeaveTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        #endregion

        #region ACTION RESULTS

        #region INDEX

        // GET: api/<LeaveTypeController>
        [HttpGet("LeaveTypeSelectList")]
        public async Task<ActionResult<List<LeaveTypeSelectListDto>>> Get()
        {
            var leaveTypeSelectList = await _mediator.Send(new GetLeaveTypeListRequest());
            return Ok(leaveTypeSelectList);

        }

        #endregion

        #endregion


    }
}
