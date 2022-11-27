using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PlayBeforeYouDie.Infrastructure.Data.Configuration;
using PlayBeforeYouDie.Infrastructure.Data.Models.Users;

namespace PlayBeforeYouDie.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new GameConfiguration());
            builder.ApplyConfiguration(new GenreConfiguration());


            builder.Entity<ApplicationUser>()
                .Property(u => u.UserName)
                .HasMaxLength(60)
                .IsRequired();

            builder.Entity<ApplicationUser>()
                .Property(u => u.Email)
                .HasMaxLength(60)
                .IsRequired();


            base.OnModelCreating(builder);
        }
    }
}