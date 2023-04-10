#region NAMESPACES
using Dapper;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.DapperRepositories;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.Employee;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.User;
using Invo.izin.Yönetim.Sistemi.Persistance.Repositories.Dapper.Base;
using System.Data;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Persistance.Repositories.Dapper
{
    public class DpEmployeeTitleRepository : DapperBaseRepository, IDpEmployeeTitleService
    {
        public async Task<List<SelectEmployeeTitleDto>> GetEmployeeTitleSelectList()
        {
            using (IDbConnection dbConnection = _connection)
            {
                string query = @"select Id,TitleName As Value from Hr.EmployeeTitle";

                var userList = await dbConnection.QueryAsync<SelectEmployeeTitleDto>(query);

                return userList.ToList();
            }
        }



    }
}
