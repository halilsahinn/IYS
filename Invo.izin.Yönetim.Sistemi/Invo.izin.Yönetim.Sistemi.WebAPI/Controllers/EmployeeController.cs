#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Application.DTOs.Employee;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.LeaveRequest;
using Invo.izin.Yönetim.Sistemi.Application.Feautures.Employee.Commands.Create;
using Invo.izin.Yönetim.Sistemi.Application.Feautures.Employee.Queries;
using Invo.izin.Yönetim.Sistemi.Application.Responses;
using Invo.izin.Yönetim.Sistemi.WebAPI.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;
#endregion


namespace Invo.izin.Yönetim.Sistemi.WebAPI.Controllers
{
    #region ATTRIBUTES

    #endregion

    public class EmployeeController : BaseController
    {
        #region FIELDS
        private readonly IMediator _mediator;
        #endregion

        #region CTOR

        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        #endregion

        #region ACTION RESULTS

        #region CREATE
        // POST api/<EmployeeController>
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]

        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] AddEmployeeDto addEmployeeDto)
        {
            // var user = _httpContextAccessor.HttpContext.User;
            var command = new CreateEmployeeCommand { addEmployeeDto = addEmployeeDto };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        #endregion

        #region INDEX

        // GET: api/<EmployeeController>
        [HttpGet("EmployeeList")]
        public async Task<ActionResult<List<EmployeeDto>>> GetEmployeeList()
        {
            var leaveRequestList = await _mediator.Send(new GetEmployeeListRequest());
            return Ok(leaveRequestList);

        }
        

        #endregion


        #endregion

    }
}
