using PlayBeforeYouDie.Infrastructure.Constants.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace PlayBeforeYouDie.Core.Models.HowLongToBeat;

public class HowLongToBeatModel
{
    public int Id { get; set; }

    [StringLength(ModelsConstants.GameTitleMaxLength, MinimumLength = ModelsConstants.GameTitleMinLength)]
    public string? GamesTitle { get; set; } 

    public string? ImageUrl { get; set; } 

    [Required]
    [StringLength(ModelsConstants.MainStoryMaxLength, MinimumLength = ModelsConstants.MainStoryMinLength)]
    [Display(Name = "Main Story")]
    public string MainStory { get; set; } = null!;

    [Required]
    [StringLength(ModelsConstants.MainPlusSidesMaxLength, MinimumLength = ModelsConstants.MainPlusSidesMinLength)]
    [Display(Name = "Main Plus Sides")]
    public string MainPlusSides { get; set; } = null!;

    [Required]
    [StringLength(ModelsConstants.HundredPercentCompleteMaxLength, MinimumLength = ModelsConstants.HundredPercentCompleteMinLength)]
    [Display(Name = "100% Complete")]
    public string HundredPercentComplete { get; set; } = null!;

    [StringLength(ModelsConstants.SpeedRunMaxLength, MinimumLength = ModelsConstants.SpeedRunMinLength)]
    [Display(Name = "Speedrun")]
    public string? SpeedRunAny { get; set; }

    [StringLength(ModelsConstants.SpeedRunOneHundredPercentMaxLength, MinimumLength = ModelsConstants.SpeedRunOneHundredPercentMinLength)]
    [Display(Name = "Speedrun 100%")]
    public string? SpeedRunOneHundredPercent { get; set; }
    
}