using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlayBeforeYouDie.Infrastructure.Data.Models;

namespace PlayBeforeYouDie.Infrastructure.Data.Configuration;

internal class GenreConfiguration : IEntityTypeConfiguration<Genre>
{
    public void Configure(EntityTypeBuilder<Genre> builder)
    {
        builder.HasData(CreateGenre());
    }

    public List<Genre> CreateGenre()
    {
        var genre = new List<Genre>()
        {
            new Genre()
            {
                Id = 1,
                Category = "MMOs"
            },
            new Genre()
            {
                Id = 2,
                Category = "Role-playing"
            },
            new Genre()
            {
                Id = 3,
                Category = "Adventure"
            },
            new Genre()
            {
                Id = 4,
                Category = "Shooter"
            },
            new Genre()
            {
                Id = 5,
                Category = "Sport games"
            },
            new Genre()
            {
                Id = 6,
                Category = "Fighting"
            },
            new Genre()
            {
                Id = 7,
                Category = "Racing"
            },
            new Genre()
            {
                Id = 8,
                Category = "Virtual Reality"
            },
            new Genre()
            {
                Id = 9,
                Category = "Strategy"
            }
        };

        return genre;

    }
}