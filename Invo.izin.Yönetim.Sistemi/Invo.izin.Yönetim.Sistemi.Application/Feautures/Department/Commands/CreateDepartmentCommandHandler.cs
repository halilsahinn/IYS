#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Application.Contracts.UnitOfWork;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.Department;
using Invo.izin.Yönetim.Sistemi.Application.Feautures.Base;
using Invo.izin.Yönetim.Sistemi.Application.Responses;
using Invo.izin.Yönetim.Sistemi.Application.ValidationRules.Department;
using Invo.izin.Yönetim.Sistemi.Domain.Employee;
using AutoMapper;
using MediatR;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Application.Feautures.Department.Commands
{

    #region COMMAND

    public sealed record CreateDepartmentCommand : IRequest<BaseCommandResponse>
    {
        public AddDepartmentDto addDepartmentDto { get; set; }
    }

    #endregion


    #region HANDLER

    public sealed class CreateDepartmentCommandHandler : BaseHandler, IRequestHandler<CreateDepartmentCommand, BaseCommandResponse>
    {
        #region CTOR
        public CreateDepartmentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {

        }
        #endregion

        #region METHODS
        public async Task<BaseCommandResponse> Handle(CreateDepartmentCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new AddDepartmentDtoValidator();
            var validationResult = await validator.ValidateAsync(request.addDepartmentDto);

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Departman Ekleme Hatalı";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
            }
            else
            {
                var result = _mapper.Map<DepartmentEntity>(request.addDepartmentDto);

                result = await _unitOfWork.DepartmentService.Add(result);
                await _unitOfWork.Save();



                response.Success = true;
                response.Message = "Departman Ekleme Başarılı";
                response.Id = result.Id;

            }


            return response;
        }

        #endregion
    }


    #endregion

}
