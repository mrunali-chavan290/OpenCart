//using Microsoft.AspNetCore.Identity;

//namespace ECom.Repository.Models
//{
//    public class ApplicationUser : IdentityUser
//    {
//        // Add custom properties here if needed
//    }
//}
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore;
//using ECom.Repository.Models;

//namespace ECom.Repository.Data
//{
//    public class AppDbContext : IdentityDbContext<ApplicationUser>
//    {
//        public AppDbContext(DbContextOptions<AppDbContext> options)
//            : base(options)
//        {
//        }

//        // Add DbSet properties for your entities here if needed
//    }
//}
using Microsoft.AspNetCore.Identity;

namespace ECom.Repository.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? Username { get; set; }
        public string? RoleType { get; set; }
    }
}
