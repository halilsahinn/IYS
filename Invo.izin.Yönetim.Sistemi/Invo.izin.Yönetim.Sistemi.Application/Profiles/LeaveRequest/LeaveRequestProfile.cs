#region NAMESPACES
using AutoMapper;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.LeaveRequest;
using Invo.izin.Yönetim.Sistemi.Domain.Leave;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Application.Profiles.LeaveRequest
{
    public class LeaveRequestProfile : Profile
    {
        public LeaveRequestProfile()
        {
            CreateMap<LeaveRequestEntity, AddLeaveRequestDto>().ReverseMap();
        }

    }
}
