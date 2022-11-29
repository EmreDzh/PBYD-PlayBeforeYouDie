using PlayBeforeYouDie.Infrastructure.Constants.Infrastructure;
using System.ComponentModel.DataAnnotations;
using PlayBeforeYouDie.Core.Models.Genre;
using PlayBeforeYouDie.Core.Models.HowLongToBeat;
using PlayBeforeYouDie.Core.Models.Mod;

namespace PlayBeforeYouDie.Core.Models.Game;

public class GameModel
{
    public int Id { get; set; }

    [Required]
    [StringLength(ModelsConstants.GameTitleMaxLength, MinimumLength = ModelsConstants.GameTitleMinLength)]
    public string GameTitle { get; set; } = null!;

    [Required]
    [StringLength(ModelsConstants.SummaryMaxLength, MinimumLength = ModelsConstants.SummaryMaxLength)]
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


    [Display(Name = "HowLongToBeat")]
    public int HowLongToBeatId { get; set; }

    public IEnumerable<HowLongToBeatModel> HowLongToBeat { get; set; } = new List<HowLongToBeatModel>();


    [Display(Name = "Mods")]
    public int ModId { get; set; }

    public IEnumerable<ModModel> Mods { get; set; } = new List<ModModel>();
}