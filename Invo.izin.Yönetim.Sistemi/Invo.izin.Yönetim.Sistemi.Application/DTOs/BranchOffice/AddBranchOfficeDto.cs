using Invo.izin.Yönetim.Sistemi.Application.DTOs.Base;

namespace Invo.izin.Yönetim.Sistemi.Application.DTOs.BranchOffice
{
    public class AddBranchOfficeDto : BaseDto<byte>
    {
        public string BranchOfficeName { get; set; }
    }
}
