using PlayBeforeYouDie.Infrastructure.Constants.Infrastructure;
using System.ComponentModel.DataAnnotations;
using PlayBeforeYouDie.Core.Models.Genre;
using PlayBeforeYouDie.Core.Models.HowLongToBeat;
using PlayBeforeYouDie.Core.Models.Mod;
using PlayBeforeYouDie.Core.Models.SystemRequirement;

namespace PlayBeforeYouDie.Core.Models.Game;

public class GameModel
{
    public int Id { get; set; }

    [Required]
    [StringLength(ModelsConstants.GameTitleMaxLength, MinimumLength = ModelsConstants.GameTitleMinLength)]
    public string GameTitle { get; set; } = null!;

    [Required]
    [StringLength(ModelsConstants.SummaryMaxLength, MinimumLength = ModelsConstants.SummaryMinLength)]
    public string Summary { get; set; } = null!;

    [Required]
    public string ImageUrl { get; set; } = null!;

    [Required]
    [Display(Name = "Game Rating")]
    [Range(0.0, ModelsConstants.RatingMaxValue, ErrorMessage = "Rating must be between 0 and 100!")]
    public decimal Rating { get; set; }

    [Display(Name = "Genre")]
    public int GenreId { get; set; }

    public IEnumerable<GenreModel> Genres { get; set; } = new List<GenreModel>();


}