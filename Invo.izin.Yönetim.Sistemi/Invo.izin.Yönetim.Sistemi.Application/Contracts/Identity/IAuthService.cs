#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Application.Request;
using Invo.izin.Yönetim.Sistemi.Application.Responses;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Application.Contracts.Identity
{
    public interface IAuthService
    {
        Task<AuthResponse> Login(AuthRequest request);
        Task<RegistrationResponse> Register(RegistrationRequest request);

    }
}
