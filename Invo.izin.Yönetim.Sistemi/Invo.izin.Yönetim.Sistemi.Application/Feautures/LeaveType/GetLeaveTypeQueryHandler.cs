#region NAMESPACES
using AutoMapper;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.DapperRepositories;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Redis;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.LeaveRequest;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.LeaveType;
using Invo.izin.Yönetim.Sistemi.Application.Feautures.Base;
using MediatR;
#endregion

namespace Invo.izin.Yönetim.Sistemi.Application.Feautures.LeaveTYpe
{
    #region QUERY
    public class GetLeaveTypeListRequest : IRequest<List<LeaveTypeSelectListDto>>
    {
    }
    #endregion

    #region HANDLER
    public class GetLeaveTypeQueryHandler : BaseHandler, IRequestHandler<GetLeaveTypeListRequest, List<LeaveTypeSelectListDto>>
    {
        #region FILEDS
        private readonly IDpLeaveTypeService _leaveTypeRepository;
        #endregion

        #region CTOR
        public GetLeaveTypeQueryHandler(IDpLeaveTypeService leaveTypeRepository, IMapper mapper) : base(mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
        }
        #endregion

        #region METHODS
        public async Task<List<LeaveTypeSelectListDto>> Handle(GetLeaveTypeListRequest request, CancellationToken cancellationToken)
        {
         
            var leaveTypeList = await _leaveTypeRepository.GetLeaveTypeSelectList();

            return leaveTypeList;

        }


        #endregion
    }

    #endregion
}
