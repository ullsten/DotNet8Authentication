using Microsoft.AspNetCore.Identity;

namespace DotNet8Authentication.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
    }
}
