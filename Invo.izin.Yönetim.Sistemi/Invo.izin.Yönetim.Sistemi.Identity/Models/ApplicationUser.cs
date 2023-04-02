using Microsoft.AspNetCore.Identity;

namespace Invo.izin.Yönetim.Sistemi.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


    }
}
