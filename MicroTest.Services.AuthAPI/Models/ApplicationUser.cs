using Microsoft.AspNetCore.Identity;

namespace MicroTest.Services.AuthAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
