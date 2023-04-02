#region NAMESPACES
using System.Runtime.Serialization;
#endregion

namespace Invo.izin.Yönetim.Sistemi.Application.Exceptions
{
    public class DatabaseValidationException : Exception
    {
        #region CTOR
        public DatabaseValidationException()
        {
        }
        #endregion

        #region OVERLOADS
        public DatabaseValidationException(string? message) : base(message)
        {
        }

        public DatabaseValidationException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DatabaseValidationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
        #endregion

    }
}
