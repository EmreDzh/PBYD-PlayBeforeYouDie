using Microsoft.AspNetCore.Identity;
using PlayBeforeYouDie.Infrastructure.Data.Models.Users;
using System;
using PlayBeforeYouDie.Infrastructure.Constants.Infrastructure;

namespace PlayBeforeYouDie.Infrastructure.Data;

public static class ContextSeed
{
    public static async Task SeedRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        //Seed Roles
        await roleManager.CreateAsync(new IdentityRole(RolesEnum.Administrator.ToString()));
        
    }

    public static async Task SeedAdminAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        //Seed gamemaster user into the Administrator Role
        var defaultUser = new ApplicationUser
        {
            UserName = "gamemaster",
            Email = "gamemaster@gmail.com",
            NormalizedUserName = "gamemaster",
            NormalizedEmail = "gamemaster@gmail.com",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true
        };
        if (userManager.Users.All(u => u.Id != defaultUser.Id))
        {
            var user = await userManager.FindByEmailAsync(defaultUser.Email);
            if (user == null)
            {
                await userManager.CreateAsync(defaultUser, "Admin1234");
                await userManager.AddToRoleAsync(defaultUser, RolesEnum.Administrator.ToString());
                
            }

        }
    }
}