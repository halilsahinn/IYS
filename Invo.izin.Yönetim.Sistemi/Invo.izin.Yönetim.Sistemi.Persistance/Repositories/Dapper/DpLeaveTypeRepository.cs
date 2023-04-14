#region NAMESPACES
using Dapper;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.DapperRepositories;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.BranchOffice;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.LeaveType;
using Invo.izin.Yönetim.Sistemi.Persistance.Repositories.Dapper.Base;
using System.Data;
#endregion

namespace Invo.izin.Yönetim.Sistemi.Persistance.Repositories.Dapper
{
    public class DpLeaveTypeRepository : DapperBaseRepository, IDpLeaveTypeService
    {
        public async Task<List<LeaveTypeSelectListDto>> GetLeaveTypeSelectList()
        {
            using (IDbConnection dbConnection = _connection)
            {
                string query = @"select Id,LeaveTypeName as Value from Hr.LeaveType";

                var leaveTypeList = await dbConnection.QueryAsync<LeaveTypeSelectListDto>(query);

                return leaveTypeList.ToList();
            }
        }
    }
}
