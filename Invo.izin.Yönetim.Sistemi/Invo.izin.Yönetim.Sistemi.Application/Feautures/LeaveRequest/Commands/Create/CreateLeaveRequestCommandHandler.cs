#region NAMESPACES
using AutoMapper;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.UnitOfWork;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.Employee;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.LeaveRequest;
using Invo.izin.Yönetim.Sistemi.Application.Feautures.Base;
using Invo.izin.Yönetim.Sistemi.Application.Responses;
using Invo.izin.Yönetim.Sistemi.Application.ValidationRules.Employee;
using Invo.izin.Yönetim.Sistemi.Application.ValidationRules.LeaveRequest;
using Invo.izin.Yönetim.Sistemi.Domain.Employee;
using Invo.izin.Yönetim.Sistemi.Domain.Leave;
using MediatR;
#endregion


namespace Invo.izin.Yönetim.Sistemi.Application.Feautures.LeaveRequest.Commands.Create
{
 
    #region COMMAND

    public sealed record CreateLeaveRequestCommand : IRequest<BaseCommandResponse>
    {
        public AddLeaveRequestDto addLeaveRequestDto { get; set; }
    }

    #endregion


    #region HANDLER

    public sealed class CreateLeaveRequestCommandHandler : BaseHandler, IRequestHandler<CreateLeaveRequestCommand, BaseCommandResponse>
    {
        #region CTOR
        public CreateLeaveRequestCommandHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {

        }
        #endregion

        #region METHODS
        public async Task<BaseCommandResponse> Handle(CreateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new AddLeaveRequestDtoValidator();
            var validationResult = await validator.ValidateAsync(request.addLeaveRequestDto);

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "İzin Ekleme Hatalı";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
            }
            else
            {
                var result = _mapper.Map<LeaveRequestEntity>(request.addLeaveRequestDto);

                result = await _unitOfWork.LeaveRequestService.Add(result);
                await _unitOfWork.Save();



                response.Success = true;
                response.Message = "İzin Ekleme Başarılı";
                response.Id = result.Id;

            }


            return response;
        }

        #endregion
    }


    #endregion
}
