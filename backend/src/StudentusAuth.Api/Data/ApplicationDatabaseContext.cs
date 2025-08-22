using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace StudentusAuth.Data;

public class ApplicationDatabaseContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDatabaseContext(DbContextOptions options)
        : base(options)
    {
    }
}