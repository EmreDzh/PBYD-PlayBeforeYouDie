using System.ComponentModel.DataAnnotations;

namespace PlayBeforeYouDie.Infrastructure.Data.Models;

public class GameOfTheYear
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int Year { get; set; }

    [Required] 
    public string ImageUrl { get; set; } = null!;

    [Required] 
    public string GameTitle { get; set; } = null!;

    [Required] 
    public string Developers { get; set; } = null!;

}