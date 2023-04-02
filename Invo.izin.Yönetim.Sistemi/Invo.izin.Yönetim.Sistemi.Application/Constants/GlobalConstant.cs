namespace Invo.izin.Yönetim.Sistemi.Application.Constants
{
    public class GlobalConstant
    {
        #region SUMMARY
        /// <summary>
        /// Uygulamanın gerek duyduğu global ayarlar burada tanımlanır.
        /// </summary>
        #endregion

        #region APPLICATION
        public class Application
        {
            public const string Name = "İzin Yönetim Sistemi";
        }

        #endregion

        #region SYSTEM
        public const string MACHINE_NAME = "DESKTOP-3J337II";

        #endregion

        #region DATABASE

        public class Database
        {
            public const string SERVER_ADRDESS = "";
            public const string NAME = "IYS_DB";
            public const string USER_NAME = "";
            public const string PASSWORD = "";
            public const string CONNECTION_STRING = $@"Server={MACHINE_NAME};Database={NAME};Trusted_Connection=True;Connect Timeout = 30; MultipleActiveResultSets=True;TrustServerCertificate=True";
            public const int    DB_PORT = 1433;
            public const string DEFAULT_SCHEMA = "dbo";

        }

        #endregion


    }
}
