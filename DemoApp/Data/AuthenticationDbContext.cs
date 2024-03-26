using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DemoApp.Data;
public class AuthenticationDbContext(DbContextOptions<AuthenticationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
}

public class ApplicationUser : IdentityUser
{
}