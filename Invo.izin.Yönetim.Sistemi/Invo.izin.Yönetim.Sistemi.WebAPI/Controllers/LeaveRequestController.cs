#region NAMESPACES
using Azure;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.LeaveRequest;
using Invo.izin.Yönetim.Sistemi.Application.Feautures.LeaveRequest.Commands.Create;
using Invo.izin.Yönetim.Sistemi.Application.Feautures.LeaveRequest.Commands.Update;
using Invo.izin.Yönetim.Sistemi.Application.Feautures.LeaveRequest.Queries;
using Invo.izin.Yönetim.Sistemi.Application.Responses;
using Invo.izin.Yönetim.Sistemi.WebAPI.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;
#endregion

namespace Invo.izin.Yönetim.Sistemi.WebAPI.Controllers
{
    public class LeaveRequestController : BaseController
    {
        #region FIELDS
        private readonly IMediator _mediator;
        #endregion

        #region CTOR

        public LeaveRequestController(IMediator mediator)
        {
            _mediator = mediator;
        }

        #endregion

        #region ACTION RESULTS

        #region INDEX

        // GET: api/<LeaveRequestController>
        [HttpGet]
        public async Task<ActionResult<List<LeaveRequestDto>>> GetAll()
        {
            var leaveRequestList = await _mediator.Send(new GetLeaveRequestListRequest());
            return Ok(leaveRequestList);

        }
        // GET: api/<LeaveRequestController>
        [HttpGet("id")]
        public async Task<ActionResult<LeaveRequestDto>> GetById( int id )
        {
            var leaveRequestById = await _mediator.Send(new GetLeaveRequestByIdRequest { Id = id });
            return Ok(leaveRequestById);

        }


        #endregion

        #region CREATE
        // POST api/<LeaveRequestController>
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]

        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] AddLeaveRequestDto addLeaveRequestDto)
        {
            // var user = _httpContextAccessor.HttpContext.User;
            var command = new CreateLeaveRequestCommand { addLeaveRequestDto = addLeaveRequestDto };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

    #endregion

    #region UPDATE
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult<BaseCommandResponse>> UpdateLeaveRequestApproved([FromBody] UpdateLeaveRequestApproveDto updateLeaveRequestApproveDto)
        {
            var command =  new LeaveRequestApporvedRequest { Id = updateLeaveRequestApproveDto.Id };
            var response = await _mediator.Send(command);
            return Ok(response);
       

        }


        #endregion


        #endregion
    }
}
