using PlayBeforeYouDie.Infrastructure.Constants.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace PlayBeforeYouDie.Core.Models.Game;

public class GameServiceModel
{
    public int Id { get; set; }

   
    public string GameTitle { get; set; } = null!;

    
    public string Summary { get; set; } = null!;

    
    public string ImageUrl { get; set; } = null!;

    
    [Display(Name = "Game Rating")]
    
    public decimal Rating { get; set; }

   

    
}