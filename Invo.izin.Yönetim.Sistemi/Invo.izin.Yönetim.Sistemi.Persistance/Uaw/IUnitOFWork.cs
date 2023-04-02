#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories.Parameter;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Persistance.UnitOfWork
{
    public interface IUnitOFWork:IDisposable
    {
        IEmployeeService EmployeeService { get; }
        ILeaveRequestService LeaveRequestService { get; }

        IBranchOfficeService BranchOfficeService { get; }
        IDepartmentOfHeadService DepartmentOfHeadService { get; }
        IDepartmentService DepartmentService { get; }

        IEmployeeTitleService EmployeeTitleService { get; }
        ILeavePermissionLevelService LeavePermissionLevelService { get; }

        ILeaveTypeService LeaveTypeService { get;}

       Task Save();
    }
}