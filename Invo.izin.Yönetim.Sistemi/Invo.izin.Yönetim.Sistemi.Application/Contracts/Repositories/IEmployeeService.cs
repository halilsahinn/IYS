#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories.Base;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.Employee;
using Invo.izin.Yönetim.Sistemi.Domain.Employee;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories
{
    public interface IEmployeeService : IGenericBaseRepository<EmployeeEntity>
    {

        public Task<List<EmployeeEntity>> GetEmployeeWithParameters();

    }
}
