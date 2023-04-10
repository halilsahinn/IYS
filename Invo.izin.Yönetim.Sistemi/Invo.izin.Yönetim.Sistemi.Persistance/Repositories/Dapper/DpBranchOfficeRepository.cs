#region NAMESPACES
using Dapper;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.DapperRepositories;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.BranchOffice;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.Employee;
using Invo.izin.Yönetim.Sistemi.Persistance.Repositories.Dapper.Base;
using System.Data;
#endregion


namespace Invo.izin.Yönetim.Sistemi.Persistance.Repositories.Dapper
{
    public class DpBranchOfficeRepository : DapperBaseRepository, IDpBranchOfficeService
    {
        public async Task<List<SelectBranchOfficetDto>> GetBranchOfficeSelectList()
        {
            using (IDbConnection dbConnection = _connection)
            {
                string query = @"select Id,[BranchOfficeName] AS Value from Hr.[ BranchOffice ]";

                var userList = await dbConnection.QueryAsync<SelectBranchOfficetDto>(query);

                return userList.ToList();
            }
        }
    }
}
