#region NAMESPACES
using AutoMapper;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.BranchOffice;
using Invo.izin.Yönetim.Sistemi.Domain.Parameter;
#endregion


namespace Invo.izin.Yönetim.Sistemi.Application.Profiles.BranchOffice
{
    public class BranchOfficeProfile : Profile
    {

        public BranchOfficeProfile()
        {
            CreateMap<BranchOfficeEntity, AddBranchOfficeDto>().ReverseMap();
            CreateMap<BranchOfficeEntity, BranchOfficeDto>().ReverseMap();

        }
    }
}
