#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Application.DTOs.Department;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.User;
using Invo.izin.Yönetim.Sistemi.Application.Feautures.Department.Commands;
using Invo.izin.Yönetim.Sistemi.Application.Feautures.Department.Queries;
using Invo.izin.Yönetim.Sistemi.Application.Responses;
using Invo.izin.Yönetim.Sistemi.WebAPI.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;

#endregion

namespace Invo.izin.Yönetim.Sistemi.WebAPI.Controllers.Parameter
{
    public class DepartmentController : BaseController
    {
        #region FIELDS
        private readonly IMediator _mediator;

        #endregion

        #region CTOR

        public DepartmentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        #endregion

        #region ACTION RESULTS

        #region CREATE
        // POST api/<DepartmentController>
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]

        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] AddDepartmentDto addDepartment)
        {
            // var user = _httpContextAccessor.HttpContext.User;
            var command = new CreateDepartmentCommand { addDepartmentDto = addDepartment };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        #endregion

        #region INDEX
        // GET: api/<DepartmentController>
        [HttpGet]
        public async Task<ActionResult<List<DepartmentDto>>> Get()
        {
            var departments = await _mediator.Send(new GetDepartmentListRequest());
            return Ok(departments);
        }

        // GET: api/<DepartmentController>
        [HttpGet("DepartmentSelectList")]
        public async Task<ActionResult<List<SelectDepartmentDto>>> GetDepartmentSeletList()
        {
            var departments = await _mediator.Send(new GetDepartmentSelectListRequest());
            return Ok(departments);
        }

        #endregion

        #endregion




    }
}
