using Microsoft.AspNetCore.Identity;

namespace BlazorAuthStarter.Models;

public class Roles: IdentityUserRole<string>
{
    public virtual User User { get; set; }
    public virtual Role Role { get; set; }
}