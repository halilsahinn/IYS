#region NAMESPACES
using AutoMapper;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.Employee;
using Invo.izin.Yönetim.Sistemi.Domain.Employee;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Application.Profiles.Employee
{
    public class EmployeeProfile : Profile
    {

        public EmployeeProfile()
        {
            CreateMap<EmployeeEntity, AddEmployeeDto>().ReverseMap();
            
            CreateMap<EmployeeEntity, EmployeeDto>()
            .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.Department.DepartmentName))
            .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title.TitleName))
            .ForMember(dest => dest.BranchOfficeName, opt => opt.MapFrom(src => src.BranchOffice.BranchOfficeName))
            .ReverseMap();
        }
    }
}
