#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Application.DTOs.BranchOffice;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.Department;
using Invo.izin.Yönetim.Sistemi.Application.Feautures.BrancOffice.Commands;
using Invo.izin.Yönetim.Sistemi.Application.Feautures.BrancOffice.Queries;
using Invo.izin.Yönetim.Sistemi.Application.Feautures.Department.Commands;
using Invo.izin.Yönetim.Sistemi.Application.Feautures.Department.Queries;
using Invo.izin.Yönetim.Sistemi.Application.Responses;
using Invo.izin.Yönetim.Sistemi.WebAPI.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;
#endregion

namespace Invo.izin.Yönetim.Sistemi.WebAPI.Controllers.Parameter
{
    public class BranchOfficeController : BaseController
    {

        #region FIELDS
        private readonly IMediator _mediator;
        #endregion

        #region CTOR

        public BranchOfficeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        #endregion

        #region ACTION RESULTS

        #region CREATE
        // POST api/<BranchOfficeController>
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]

        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] AddBranchOfficeDto addBranchOfficeDto)
        {
            // var user = _httpContextAccessor.HttpContext.User;
            var command = new CreateBrancOfficeCommand { addBranchOfficeDto = addBranchOfficeDto };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        #endregion

        #region INDEX
        // GET: api/<BranchOfficeController>
        [HttpGet("BranchOfficeList")]
        public async Task<ActionResult<List<BranchOfficeDto>>> Get()
        {
            var branchOffices = await _mediator.Send(new GetBranchOfficeListRequest());
            return Ok(branchOffices);
        }

        // GET: api/<BranchOfficeController>
        [HttpGet("BranchOfficeSelectList")]
        public async Task<ActionResult<List<SelectBranchOfficetDto>>> GetBranchOfficeSelectList()
        {
            var branchOfficeList = await _mediator.Send(new GetBranchOfficeSelectListRequest());
            return Ok(branchOfficeList);
        }


        

        #endregion

        #endregion

    }
}
