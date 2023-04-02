#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories.Base;
using Invo.izin.Yönetim.Sistemi.Domain.Employee;
using Invo.izin.Yönetim.Sistemi.Domain.Leave;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories.Parameter
{
    public interface IDepartmentService : IGenericBaseRepository<DepartmentEntity>
    {
    }
}
