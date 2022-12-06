using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PlayBeforeYouDie.Infrastructure.Data.Configuration;
using PlayBeforeYouDie.Infrastructure.Data.Models;
using PlayBeforeYouDie.Infrastructure.Data.Models.Users;

namespace PlayBeforeYouDie.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<HowLongToBeat> HowLongToBeat { get; set; }

        public DbSet<Mod> Mods { get; set; }

        public DbSet<SystemRequirement> SystemRequirements { get; set; }

        public DbSet<ModPicture> ModPictures { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new GameConfiguration());
            builder.ApplyConfiguration(new GenreConfiguration());
            builder.ApplyConfiguration(new SystemRequirementConfiguration());
            builder.ApplyConfiguration(new HowLongToBeatConfiguration());
            builder.ApplyConfiguration(new ModConfiguration());
            builder.ApplyConfiguration(new ModPictureConfiguration());

            builder.Entity<ApplicationUserGame>()
                .HasKey(x => new
                {
                    x.ApplicationUserId, x.GameId
                });

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