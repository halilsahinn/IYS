using Invo.izin.Yönetim.Sistemi.Application.DTOs.BranchOffice;

namespace Invo.izin.Yönetim.Sistemi.Application.Contracts.DapperRepositories
{
    public interface IDpBranchOfficeService
    {
        public Task<List<SelectBranchOfficetDto>> GetBranchOfficeSelectList();
    }
}
