using Microsoft.EntityFrameworkCore;

namespace StudentusAuth.Data;

public class ApplicationDatabaseContext : DbContext
{
    public ApplicationDatabaseContext(DbContextOptions options)
        : base(options)
    {
    }
}