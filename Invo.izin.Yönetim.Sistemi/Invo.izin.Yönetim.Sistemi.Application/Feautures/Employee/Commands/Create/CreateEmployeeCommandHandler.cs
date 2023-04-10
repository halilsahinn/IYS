#region NAMESPACES
using AutoMapper;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.UnitOfWork;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.Employee;
using Invo.izin.Yönetim.Sistemi.Application.Feautures.Base;
using Invo.izin.Yönetim.Sistemi.Application.Responses;
using Invo.izin.Yönetim.Sistemi.Application.ValidationRules.Employee;
using Invo.izin.Yönetim.Sistemi.Domain.Employee;
using MediatR;
#endregion


namespace Invo.izin.Yönetim.Sistemi.Application.Feautures.Employee.Commands.Create
{

    #region COMMAND

    public sealed record CreateEmployeeCommand : IRequest<BaseCommandResponse>
    {
        public AddEmployeeDto addEmployeeDto { get; set; }
    }

    #endregion


    #region HANDLER

    public sealed class CreateEmployeeCommandHandler : BaseHandler, IRequestHandler<CreateEmployeeCommand, BaseCommandResponse>
    {
        #region CTOR
        public CreateEmployeeCommandHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {

        }
        #endregion

        #region METHODS
        public async Task<BaseCommandResponse> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new AddEmployeeDtoValidator();
            var validationResult = await validator.ValidateAsync(request.addEmployeeDto);

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Çalışan Ekleme Hatalı";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
            }
            else
            {
                var result = _mapper.Map<EmployeeEntity>(request.addEmployeeDto);

                result = await _unitOfWork.EmployeeService.Add(result);
                await _unitOfWork.Save();



                response.Success = true;
                response.Message = "Çalışan Ekleme Başarılı";
                response.Id = result.Id;

            }


            return response;
        }

        #endregion
    }


    #endregion

}
