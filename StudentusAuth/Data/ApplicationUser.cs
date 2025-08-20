using Microsoft.AspNetCore.Identity;

namespace StudentusAuth.Data;

public class ApplicationUser : IdentityUser
{
    public string HashedEmail { get; set; }
}