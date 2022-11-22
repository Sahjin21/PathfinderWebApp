using Microsoft.AspNetCore.Identity;

namespace PathfinderWebApp.Models
{
    //public class AppUser : IdentityUser
    public class AppUser
    {

        public string Email { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
