using Microsoft.AspNetCore.Identity;

namespace ECom.Repository.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; } = string.Empty;
    }
}

