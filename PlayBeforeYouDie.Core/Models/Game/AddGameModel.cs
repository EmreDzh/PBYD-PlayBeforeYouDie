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

    //Game Gerne
    public IEnumerable<GenreModel> Genres { get; set; } = new List<GenreModel>();

    [Display(Name = "Genre")]
    public int GenreId { get; set; }

    // Game System Requirements
    [Display(Name = "System Requirements")]
    public int SystemRequirementId { get; set; }

    public string Os { get; set; } = null!;

    public string Processor { get; set; } = null!;

    public string Memory { get; set; } = null!;

    public string Graphics { get; set; } = null!;

    public string Network { get; set; } = null!;

    public string Storage { get; set; } = null!;

    public string? AdditionalNotes { get; set; }

    
    //Game Mods
    
    [Display(Name = "Mod Name")]
    public string ModName { get; set; } = null!;

    
    [Display(Name = "Description for the Mod")]
    public string Description { get; set; } = null!;

    
    [Display(Name = "Link to download the Mod")]
    public string DownloadModLink { get; set; } = null!;

    [Display(Name = "Youtube Video Link")]
    public string? YoutubeVideoModComparison { get; set; }

    public int ModImageId { get; set; }

    [Display(Name = "1st Mod Image")]
    public string ModImageOne { get; set; } = null!;


    //Game HowLongToBeat

    
    public string? GamesTitle { get; set; } = null!;

    public string? HowLongToBeatImageUrl { get; set; }

    
    [Display(Name = "Main Story")]
    public string MainStory { get; set; } = null!;

    
    [Display(Name = "Main Plus Sides")]
    public string MainPlusSides { get; set; } = null!;

    
    [Display(Name = "100% Complete")]
    public string HundredPercentComplete { get; set; } = null!;

    
    [Display(Name = "Speedrun")]
    public string? SpeedRunAny { get; set; }

    [Display(Name = "Speedrun 100%")]
    public string? SpeedRunOneHundredPercent { get; set; }


}