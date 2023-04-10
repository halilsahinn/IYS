#region NAMESPACES
using Dapper;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories.User;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.User;
using Invo.izin.Yönetim.Sistemi.Persistance.Repositories.Dapper.Base;
using System.Data;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Persistance.Repositories.Dapper
{
    public class DpUserRepository : DapperBaseRepository, IDpUserService
    {
        public async Task<List<SelectUserDto>> GetUserSelectList()
        {
            using (IDbConnection dbConnection = _connection)
            {
                string query = @"select Us.Id as UserId,Us.Name from [IYS_DB].[Identity].[User] AS Us";

                var userList = await dbConnection.QueryAsync<SelectUserDto>(query);

                return userList.ToList();
            }
        }
    }
}
