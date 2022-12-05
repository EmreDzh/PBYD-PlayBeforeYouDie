using PlayBeforeYouDie.Infrastructure.Constants.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace PlayBeforeYouDie.Core.Models.Game;

public class GameHomeModel
{
    public int Id { get; set; }

    
    public string GameTitle { get; set; } = null!;

    
    public string Summary { get; set; } = null!;

    
    public string ImageUrl { get; set; } = null!;
}