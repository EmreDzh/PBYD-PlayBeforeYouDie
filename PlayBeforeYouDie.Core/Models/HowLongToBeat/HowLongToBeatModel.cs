using PlayBeforeYouDie.Infrastructure.Constants.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace PlayBeforeYouDie.Core.Models.HowLongToBeat;

public class HowLongToBeatModel
{
    public int Id { get; set; }

    [Required]
    [StringLength(ModelsConstants.MainStoryMaxLength, MinimumLength = ModelsConstants.MainStoryMinLength)]
    public string MainStory { get; set; } = null!;

    [Required]
    [StringLength(ModelsConstants.MainPlusSidesMaxLength, MinimumLength = ModelsConstants.MainPlusSidesMinLength)]
    public string MainPlusSides { get; set; } = null!;

    [Required]
    [StringLength(ModelsConstants.HundredPercentCompleteMaxLength, MinimumLength = ModelsConstants.HundredPercentCompleteMinLength)]
    public string HundredPercentComplete { get; set; } = null!;

    [StringLength(ModelsConstants.SpeedRunMaxLength, MinimumLength = ModelsConstants.SpeedRunMinLength)]
    public string? SpeedRunAny { get; set; }

    [StringLength(ModelsConstants.SpeedRunOneHundredPercentMaxLength, MinimumLength = ModelsConstants.SpeedRunOneHundredPercentMinLength)]
    public string? SpeedRunOneHundredPercent { get; set; }
}