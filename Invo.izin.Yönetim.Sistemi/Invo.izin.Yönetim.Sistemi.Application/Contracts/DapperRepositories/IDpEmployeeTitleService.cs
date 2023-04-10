#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Application.DTOs.Employee;
#endregion


namespace Invo.izin.Yönetim.Sistemi.Application.Contracts.DapperRepositories
{
    public interface IDpEmployeeTitleService
    {
        public Task<List<SelectEmployeeTitleDto>> GetEmployeeTitleSelectList();
    }
}
