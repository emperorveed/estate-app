using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace EstateApp.Data.DatabaseContext.AuthenticationDbContext
{
    public class AunthenticationDbContext : IdentityDbContext<ApplicationUser>
    {
        public AuthenticationDbContext(DbContextOptions<AunthenticationDbContext> options)
        : base(options)
        {

        }
    }
}