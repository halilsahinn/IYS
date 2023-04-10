#region NAMESPACES
using AutoMapper;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.Department;
using Invo.izin.Yönetim.Sistemi.Domain.Employee;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Application.Profiles.Department
{
    public class DepartmentProfile : Profile
    {

        public DepartmentProfile()
        {
            CreateMap<DepartmentEntity, AddDepartmentDto>().ReverseMap();
            CreateMap<DepartmentEntity, DepartmentDto>().ReverseMap();
       
        }

    }
}
