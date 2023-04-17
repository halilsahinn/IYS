#region NAMESPACES
using AutoMapper;
using FluentValidation;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.UnitOfWork;
using Invo.izin.Yönetim.Sistemi.Application.Feautures.Base;
using Invo.izin.Yönetim.Sistemi.Application.Feautures.LeaveRequest.Commands.Create;
using Invo.izin.Yönetim.Sistemi.Application.Responses;
using Invo.izin.Yönetim.Sistemi.Application.ValidationRules.LeaveRequest;
using Invo.izin.Yönetim.Sistemi.Domain.Leave;
using MediatR;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Application.Feautures.LeaveRequest.Commands.Update
{

    #region COMMAND
    public sealed record LeaveRequestApporvedRequest : IRequest<BaseCommandResponse>
    {
        public int Id { get; set; }
    }

    #endregion

    #region HANDLER
    public sealed class UpdateLeaveRequestApporvedCommandHandler : BaseHandler, IRequestHandler<LeaveRequestApporvedRequest, BaseCommandResponse>
    {
        #region CTOR
        public UpdateLeaveRequestApporvedCommandHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {

        }
        #endregion

        #region METHODS
        public async Task<BaseCommandResponse> Handle(LeaveRequestApporvedRequest request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            

            try
            {
                var result = _unitOfWork.LeaveRequestService.UpdateLeaveRequestApproved(request.Id);
                await _unitOfWork.Save();
            }
            catch (Exception ex)
            {

                response.Success = false;
                response.Message = "Onaylama Hatalı: " + ex.Message;
               
            }
            
              
            

            return response;
        }
        #endregion

    }
    #endregion


}
