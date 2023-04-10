#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Identity;
using Invo.izin.Yönetim.Sistemi.Application.Request;
using Invo.izin.Yönetim.Sistemi.Application.Responses;
using Invo.izin.Yönetim.Sistemi.WebAPI.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

#endregion

namespace Invo.izin.Yönetim.Sistemi.WebAPI.Controllers
{
    public class AccountController : BaseController
    {
        #region SUMMARY
        /// <summary>
        /// Sisteme giriş kontrollerinin yapıldığı controller.
        /// </summary>
        #endregion

        #region FIELDS
        private readonly IAuthService _authenticationService;
        #endregion

        #region CTOR

        public AccountController(IAuthService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        #endregion

        #region ACTION RESULTS
        /// <summary>
        /// Varsayılan Admin Kullanıcı Adı: admin@localhost.com Şifre: P@ssword1
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        // GET: api/<AccountController>

        [HttpPost("login")]
        public async Task<ActionResult<AuthResponse>> Login(AuthRequest request)
        {
            return Ok(await _authenticationService.Login(request));
        }

        // GET: api/<AccountController>
        [HttpPost("register")]
        public async Task<ActionResult<RegistrationResponse>> Register(RegistrationRequest request)
        {
            return Ok(await _authenticationService.Register(request));
        }

    


        #endregion   
    }
}