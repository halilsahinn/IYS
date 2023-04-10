#region NAMESPACES
using FluentValidation;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.Employee;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Application.ValidationRules.Employee
{
    public class AddEmployeeDtoValidator : AbstractValidator<AddEmployeeDto>
    {
        public AddEmployeeDtoValidator()
        {
            RuleFor(x => x.EmployeeName)
              .NotEmpty().WithMessage("Çalışan Adı Boş Geçilemez");
            


        }
    }
}
