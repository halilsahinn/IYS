#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Application.DTOs.Employee;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.EmployeeTitle;
using Invo.izin.Yönetim.Sistemi.Application.Feautures.Employee.Commands.Create;
using Invo.izin.Yönetim.Sistemi.Application.Feautures.Employee.Queries;
using Invo.izin.Yönetim.Sistemi.Application.Responses;
using Invo.izin.Yönetim.Sistemi.WebAPI.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;
#endregion


namespace Invo.izin.Yönetim.Sistemi.WebAPI.Controllers.Parameter
{
    public class EmployeeTitleController : BaseController
    {
        #region FIELDS
        private readonly IMediator _mediator;
        #endregion

        #region CTOR

        public EmployeeTitleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        #endregion

        #region ACTION RESULTS

        #region CREATE
  
        #endregion

        #region INDEX

        // GET: api/<EmployeeTitleController>
        [HttpGet("EmployeeTitleSelectList")]
        public async Task<ActionResult<List<SelectEmployeeTitleDto>>> GetEmployeeTitleList()
        {
            var leaveRequestList = await _mediator.Send(new GetEmployeeTitleRequestListRequest());
            return Ok(leaveRequestList);

        }
 


        #endregion


        #endregion
    }
}
