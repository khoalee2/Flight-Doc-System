using System.ComponentModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;


namespace Flight_Doc_System.Models
{
    public class ApplicationUser : IdentityUser   
    {
        [Display(Name = "Full Name"),Required]
        [StringLength(100)]
        public string Email { get; set; }
        public bool Gender { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplcationCookie);
            return userIdentity;
        }

        public class Application : IdentityRole
        {
            public ApplicationRole() : base() { }
            public ApplicationRole() : base(rolename) { }

        }

        public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
        {
            public ApplicationDbContext() : base("DefaultConnection", throw: false) { }
        }
    }
}
