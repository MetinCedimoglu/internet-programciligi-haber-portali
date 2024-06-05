using Microsoft.AspNetCore.Identity;

namespace HaberPortalı.Models
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
