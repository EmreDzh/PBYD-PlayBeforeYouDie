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
            UserName = "user@mail.com",
            NormalizedUserName = "user@mail.com",
            Email = "user@mail.com",
            NormalizedEmail = "user@mail.com"
        };

        user.PasswordHash =
            hasher.HashPassword(user, "user123");

        users.Add(user);
        
        return users;
    }


}