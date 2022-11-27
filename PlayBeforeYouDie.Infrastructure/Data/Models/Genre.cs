using System.ComponentModel.DataAnnotations;

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
    public string Category { get; set; } = null!;

    public List<Game> Games { get; set; }

}