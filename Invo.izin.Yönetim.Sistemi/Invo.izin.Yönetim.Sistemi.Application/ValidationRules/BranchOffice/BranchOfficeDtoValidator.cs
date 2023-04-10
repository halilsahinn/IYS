#region NAMESPACES
using FluentValidation;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.BranchOffice;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Application.ValidationRules.BranchOffice
{
    public class AddBranchOfficeDtoValidator : AbstractValidator<AddBranchOfficeDto>
    {
        public AddBranchOfficeDtoValidator()
        {
            RuleFor(x => x.BranchOfficeName)
              .NotEmpty().WithMessage("Şube Adı Boş Geçilemez");

        }
    }
}
