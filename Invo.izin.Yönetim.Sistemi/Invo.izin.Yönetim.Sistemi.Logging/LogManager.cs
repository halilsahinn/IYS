﻿#region NAMESPACES
using Serilog;
using System.Text;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Log;
#endregion


namespace Invo.izin.Yönetim.Sistemi.Logging
{
    public class LogManager : ILogService
    {
        public void Debug(string message)
        {
            Log.Debug(message);
        }

        public void Error(string message, Exception ex)
        {
            StringBuilder str = new StringBuilder();
            str.Append(message);
            str.Append(ex.Message);
            str.Append(ex.Source);

            Log.Error(str.ToString());
        }

        public void Information(string message)
        {
            Log.Information(message);
        }

        public void Warning(string message)
        {
            Log.Warning(message);
        }
    }
}
