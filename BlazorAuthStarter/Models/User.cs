using Microsoft.AspNetCore.Identity;

namespace BlazorAuthStarter.Models;

public class User: IdentityUser
{
    public virtual List<Roles>? Roles { get; set; }
}