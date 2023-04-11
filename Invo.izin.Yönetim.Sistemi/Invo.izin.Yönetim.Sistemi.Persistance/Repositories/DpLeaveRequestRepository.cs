#region NAMESPACES
using Dapper;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.DapperRepositories;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.BranchOffice;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.LeaveRequest;
using Invo.izin.Yönetim.Sistemi.Persistance.Repositories.Dapper.Base;
using System.Data;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Persistance.Repositories
{
    public class DpLeaveRequestRepository : DapperBaseRepository, IDpLeaveRequestService
    {
        public async Task<List<LeaveRequestDto>> GetLeaveRequestList()
        {
            using (IDbConnection dbConnection = _connection)
            {
                string query = @" SELECT 
E.EmployeeName,
Lr.StartedDate,
Lr.FinishedDate,
(DATEDIFF(Day,Lr.StartedDate,Lr.FinishedDate)) As LeaveTime,
Lt.LeaveTypeName,
CASE 
WHEN Lr.IsApproved= 1 THEN 'Onaylandı'
WHEN Lr.IsApproved = 0 THEN 'Onaylanlanmadı'
End As [Status],
Lr.Description
FROM  [Hr].[ LeaveRequest] As Lr
INNER JOIN Hr.LeaveType As Lt ON  Lt.Id=Lr.LeaveTypeId
INNER JOIN Hr.Employee As E On E.EmployeeId= Lr.EmployeeId
Where Lr.IsActive=1
";

                var leaveRequestList = await dbConnection.QueryAsync<LeaveRequestDto>(query);

                return leaveRequestList.ToList();
            }
        }
    }
}
