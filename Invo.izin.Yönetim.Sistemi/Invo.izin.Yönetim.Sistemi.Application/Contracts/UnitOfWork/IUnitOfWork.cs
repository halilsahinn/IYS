#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories.Parameter;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Application.Contracts.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeeService EmployeeService { get; }
        ILeaveRequestService LeaveRequestService { get; }

        IBranchOfficeService BranchOfficeService { get; }
    
        IDepartmentService DepartmentService { get; }

        IEmployeeTitleService EmployeeTitleService { get; }
        ILeavePermissionLevelService LeavePermissionLevelService { get; }

        ILeaveTypeService LeaveTypeService { get; }

        Task Save();
    }
}
