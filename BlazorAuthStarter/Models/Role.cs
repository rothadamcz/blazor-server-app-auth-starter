using Microsoft.AspNetCore.Identity;

namespace BlazorAuthStarter.Models;

public class Role: IdentityRole
{
    public virtual List<Roles>? Users { get; set; }
}