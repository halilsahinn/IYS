#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Application.DTOs.Department;
#endregion


namespace Invo.izin.Yönetim.Sistemi.Application.Contracts.DapperRepositories
{
    public interface IDpDepartmentService
    {
        public Task<List<SelectDepartmentDto>> GetDepartmentSelectList();
    }
}
