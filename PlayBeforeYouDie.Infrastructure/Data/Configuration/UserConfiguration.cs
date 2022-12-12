using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlayBeforeYouDie.Infrastructure.Data.Models.Users;

namespace PlayBeforeYouDie.Infrastructure.Data.Configuration;

internal class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.HasData(CreateUsers());
    }

    private List<ApplicationUser> CreateUsers()
    {
        var hasher = new PasswordHasher<ApplicationUser>();
        var users = new List<ApplicationUser>();

        var user = new ApplicationUser()
        {
            Id = "dea12856-c198-4129-b3f3-b893d8395082",
            UserName = "modder@mail.com",
            NormalizedUserName = "modder@mail.com",
            Email = "modder@mail.com",
            NormalizedEmail = "modder@mail.com"
        };

        user.PasswordHash =
            hasher.HashPassword(user, "modder123");

        users.Add(user);

        user = new ApplicationUser()
        {
            Id = "b1b89182-68ed-489c-93be-a108b9cb5aad",
            UserName = "Admin@mail.com",
            NormalizedUserName = "Admin@mail.com",
            Email = "Admin@mail.com",
            NormalizedEmail = "Admin@mail.com"
        };

        user.PasswordHash =
            hasher.HashPassword(user, "admin123");

        users.Add(user);
        

        return users;
    }


}