#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories.Parameter;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.UnitOfWork;
using Invo.izin.Yönetim.Sistemi.Persistance.Contex;
using Invo.izin.Yönetim.Sistemi.Persistance.Repositories.EfCore;
using Invo.izin.Yönetim.Sistemi.Persistance.Repositories.EfCore.Parameter;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Persistance.Uow
{
    public class UnitOfWork : IUnitOfWork
    {
        #region FIELDS
        private readonly IYSDbContext _context;

        private IEmployeeService _employeeService;
        private ILeaveRequestService _leaveRequestService;
        private IBranchOfficeService _branchOfficeService;
      
        private IDepartmentService _departmentService;
        private IEmployeeTitleService _employeeTitleService;
        private ILeavePermissionLevelService _leavePermissionLevelService;
        private ILeaveTypeService leaveTypeService;

        #endregion

        #region CTOR
        public UnitOfWork(IYSDbContext context)
        {
            _context = context;
        }
        #endregion

        #region INTERFACES
        public IEmployeeService EmployeeService => _employeeService ??= new EfEmployeeRepository(_context);

        public ILeaveRequestService LeaveRequestService => _leaveRequestService ??= new EfLeaveRequestRepository(_context);

        public IBranchOfficeService BranchOfficeService => _branchOfficeService ??= new EfBranchOfficeRepository(_context);

  

        public IDepartmentService DepartmentService => _departmentService ??= new EfDepartmentRepository(_context);

        public IEmployeeTitleService EmployeeTitleService => _employeeTitleService ??= new EfEmployeeTitleRepository(_context);

        public ILeavePermissionLevelService LeavePermissionLevelService => _leavePermissionLevelService ??= new EfLeavePermissionLevelRepository(_context);

        public ILeaveTypeService LeaveTypeService => leaveTypeService ??= new EfLeaveTypeRepository(_context);
        #endregion

        #region METHODS
        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
        #endregion

    }
}
