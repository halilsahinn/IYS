#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Application.Constants;
using Microsoft.Data.SqlClient;
using System.Data;
#endregion

namespace Invo.izin.Yönetim.Sistemi.Persistance.Repositories.Dapper.Base
{
    public abstract class DapperBaseRepository
    {

        #region FIELDS
        private readonly string _connectionString;
        protected IDbConnection _connection { get { return new SqlConnection(_connectionString); } }

        #endregion

        #region CTOR
        public DapperBaseRepository()
        {
            _connectionString = GlobalConstant.Database.CONNECTION_STRING;
        }
        #endregion

    }
}
