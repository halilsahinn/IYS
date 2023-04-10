#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Application.DTOs.User;
#endregion


namespace Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories.User
{
    public interface IDpUserService
    {
        public Task<List<SelectUserDto>> GetUserSelectList();

    }
}
