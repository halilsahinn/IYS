#region NAMESPACES
using FluentValidation.Results;
#endregion


namespace Invo.izin.Yönetim.Sistemi.WebAPI.Middleware
{
    public class ValidationException : ApplicationException
    {
        public List<string> Errors { get; set; } = new List<string>();

        public ValidationException(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                Errors.Add(error.ErrorMessage);
            }
        }
    }
}
