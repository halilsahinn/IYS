#region NAMESPACES
using AutoMapper;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.UnitOfWork;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.BranchOffice;
using Invo.izin.Yönetim.Sistemi.Application.Feautures.Base;
using Invo.izin.Yönetim.Sistemi.Application.Responses;
using Invo.izin.Yönetim.Sistemi.Application.ValidationRules.BranchOffice;
using Invo.izin.Yönetim.Sistemi.Application.ValidationRules.Department;
using Invo.izin.Yönetim.Sistemi.Domain.Employee;
using Invo.izin.Yönetim.Sistemi.Domain.Parameter;
using MediatR;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Application.Feautures.BrancOffice.Commands
{
    #region COMMAND

    public sealed record CreateBrancOfficeCommand : IRequest<BaseCommandResponse>
    {
        public AddBranchOfficeDto addBranchOfficeDto { get; set; }
    }

    #endregion

    #region HANDLER

    public sealed class CreateBrancOfficeCommandHandler : BaseHandler, IRequestHandler<CreateBrancOfficeCommand, BaseCommandResponse>
    {
        #region CTOR
        public CreateBrancOfficeCommandHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {

        }
        #endregion

        #region METHODS
        public async Task<BaseCommandResponse> Handle(CreateBrancOfficeCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new AddBranchOfficeDtoValidator();
            var validationResult = await validator.ValidateAsync(request.addBranchOfficeDto);

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Şube Ekleme Hatalı";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
            }
            else
            {
                var result = _mapper.Map<BranchOfficeEntity>(request.addBranchOfficeDto);

                result = await _unitOfWork.BranchOfficeService.Add(result);
                await _unitOfWork.Save();



                response.Success = true;
                response.Message = "Şube Ekleme Başarılı";
                response.Id = result.Id;

            }


            return response;
        }

        #endregion
    }


    #endregion

}
