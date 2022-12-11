using System.ComponentModel.DataAnnotations;

namespace PlayBeforeYouDie.Core.Models.GameOfTheYear;

public class GameOfTheYearModel
{
    
    public int Id { get; set; }

   
    public int Year { get; set; }

   
    public string ImageUrl { get; set; } = null!;

    
    public string GameTitle { get; set; } = null!;

    
    public string Developers { get; set; } = null!;
}