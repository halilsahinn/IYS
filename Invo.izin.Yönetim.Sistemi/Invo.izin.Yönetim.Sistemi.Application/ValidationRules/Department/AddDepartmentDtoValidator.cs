#region NAMESPACES
using FluentValidation;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.Department;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Application.ValidationRules.Department
{


    public class AddDepartmentDtoValidator : AbstractValidator<AddDepartmentDto>
    {
        public AddDepartmentDtoValidator()
        {
            RuleFor(x => x.DepartmentName)
              .NotEmpty().WithMessage("Departman Adı Boş Geçilemez");
          


        }
    }

}
