#region NAMESPACES
using AutoMapper;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.DapperRepositories;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Redis;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.UnitOfWork;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.Department;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.Employee;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.LeaveRequest;
using Invo.izin.Yönetim.Sistemi.Application.Feautures.Base;
using Invo.izin.Yönetim.Sistemi.Domain.Leave;
using MediatR;
#endregion

namespace Invo.izin.Yönetim.Sistemi.Application.Feautures.LeaveRequest.Queries
{

    #region QUERY
    public class GetLeaveRequestByIdRequest : IRequest<LeaveRequestEntity>
    {
        public int Id { get; set; }
    }
    #endregion

    #region HANDLER
    public sealed class GetLeaveRequestByIdQueryHandler : BaseHandler, IRequestHandler<GetLeaveRequestByIdRequest, LeaveRequestEntity>
    {
        #region FILEDS
        private readonly ILeaveRequestService _leaveRequestRepository;
        #endregion

        #region CTOR
        public GetLeaveRequestByIdQueryHandler(ILeaveRequestService leaveRequestRepository, IMapper mapper) : base(mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
        }
        #endregion

        #region METHODS
        public async Task<LeaveRequestEntity> Handle(GetLeaveRequestByIdRequest request, CancellationToken cancellationToken)
        {
            var result = await _leaveRequestRepository.GetLeaveRequestById(request.Id);

            return result;
        
        }


        #endregion
    }

    #endregion

}
