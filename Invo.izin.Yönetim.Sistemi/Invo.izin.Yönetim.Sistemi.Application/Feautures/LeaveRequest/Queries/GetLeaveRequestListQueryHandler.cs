#region NAMESPACES
using AutoMapper;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.DapperRepositories;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Redis;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.Employee;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.LeaveRequest;
using Invo.izin.Yönetim.Sistemi.Application.Feautures.Base;
using MediatR;
#endregion


namespace Invo.izin.Yönetim.Sistemi.Application.Feautures.LeaveRequest.Queries
{

    #region QUERY
    public record GetLeaveRequestListRequest : IRequest<List<LeaveRequestDto>>
    {
    }
    #endregion

    #region HANDLER
    public sealed class GetLeaveRequestListQueryHandler : BaseHandler, IRequestHandler<GetLeaveRequestListRequest, List<LeaveRequestDto>>
    {
        #region FILEDS
        private readonly IDpLeaveRequestService _leaveRequestRepository;
        #endregion

        #region CTOR
        public GetLeaveRequestListQueryHandler(IDpLeaveRequestService leaveRequestRepository, IMapper mapper, IRedisService redisService) : base(mapper, redisService)
        {
            _leaveRequestRepository = leaveRequestRepository;
        }
        #endregion

        #region METHODS
        public async Task<List<LeaveRequestDto>> Handle(GetLeaveRequestListRequest request, CancellationToken cancellationToken)
        {
            var cacheData = _redisService.GetData<List<LeaveRequestDto>>("leaveRequest");

            if (cacheData != null)
            {
                return cacheData;
            }

            var expirationTime = DateTimeOffset.Now.AddMinutes(5.0);
             
            cacheData = await _leaveRequestRepository.GetLeaveRequestList();

            _redisService.SetData<List<LeaveRequestDto>>("leaveRequest", cacheData, expirationTime);

            return cacheData;



        }


        #endregion
    }

    #endregion


}
