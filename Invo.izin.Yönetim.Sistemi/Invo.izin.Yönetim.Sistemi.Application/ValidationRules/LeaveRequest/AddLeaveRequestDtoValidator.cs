#region NAMESPACES
using FluentValidation;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.LeaveRequest;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Application.ValidationRules.LeaveRequest
{
    public class AddLeaveRequestDtoValidator : AbstractValidator<AddLeaveRequestDto>
    {
        public AddLeaveRequestDtoValidator()
        {
            RuleFor(x => x.EmployeeId)
            .NotEmpty().WithMessage("Çalışan Boş Geçilemez");

            RuleFor(x => x.LeaveTypeId)
            .NotEmpty().WithMessage("İzin Tipi  Boş Geçilemez");

            RuleFor(x => x.StartedDate).Must(BeAValidDate)
          .WithMessage("Başlangıç Tarihi Seçilmelidir");

            RuleFor(x => x.FinishedDate).Must(BeAValidDate)
            .WithMessage("Bitiş Tarihi Seçilmelidir");
        }

        private bool BeAValidDate(DateTime date)
        {
            return !date.Equals(default(DateTime));
        }
    }
}
