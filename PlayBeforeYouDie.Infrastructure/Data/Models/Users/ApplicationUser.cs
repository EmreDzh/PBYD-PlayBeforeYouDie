using Microsoft.AspNetCore.Identity;

namespace PlayBeforeYouDie.Infrastructure.Data.Models.Users;

public class ApplicationUser : IdentityUser
{
    public List<ApplicationUserGame> ApplicationUserGames { get; set; } = new List<ApplicationUserGame>();
}