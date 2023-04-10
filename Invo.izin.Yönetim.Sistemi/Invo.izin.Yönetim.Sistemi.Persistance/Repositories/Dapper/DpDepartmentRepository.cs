#region NAMESPACES
using Dapper;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.DapperRepositories;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.Department;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.User;
using Invo.izin.Yönetim.Sistemi.Domain.Employee;
using Invo.izin.Yönetim.Sistemi.Persistance.Repositories.Dapper.Base;
using System.Data;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Persistance.Repositories.Dapper
{
    public class DpDepartmentRepository : DapperBaseRepository, IDpDepartmentService
    {
        public async Task<List<SelectDepartmentDto>> GetDepartmentSelectList()
        {
            using (IDbConnection dbConnection = _connection)
            {
                string query = @"select Id,DepartmentName As Value from HR.department";

                var departmentList = await dbConnection.QueryAsync<SelectDepartmentDto>(query);

                return departmentList.ToList();
            }
        }
    }
}
