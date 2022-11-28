using System.ComponentModel.DataAnnotations;
using PlayBeforeYouDie.Infrastructure.Constants.Infrastructure;

namespace PlayBeforeYouDie.Infrastructure.Data.Models;

public class Genre
{
    public Genre()
    {
        Games = new List<Game>();
    }

    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(ModelsConstants.CategoryMaxLength)]
    public string Category { get; set; } = null!;

    public List<Game> Games { get; set; }

}