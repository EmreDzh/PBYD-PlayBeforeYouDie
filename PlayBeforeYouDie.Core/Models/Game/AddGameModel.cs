using PlayBeforeYouDie.Core.Models.Genre;
using PlayBeforeYouDie.Core.Models.SystemRequirement;
using PlayBeforeYouDie.Infrastructure.Constants.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace PlayBeforeYouDie.Core.Models.Game;

public class AddGameModel
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

    public IEnumerable<GenreModel> Genres { get; set; } = new List<GenreModel>();

    [Display(Name = "Genre")]
    public int GenreId { get; set; }


    [Display(Name = "System Requirements")]
    public int SystemRequirementId { get; set; }

    public string Os { get; set; } = null!;

    public string Processor { get; set; } = null!;

    public string Memory { get; set; } = null!;

    public string Graphics { get; set; } = null!;

    public string Network { get; set; } = null!;

    public string Storage { get; set; } = null!;

    public string? AdditionalNotes { get; set; }

    


}