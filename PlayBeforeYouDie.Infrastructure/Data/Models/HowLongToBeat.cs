using System.ComponentModel.DataAnnotations;
using PlayBeforeYouDie.Infrastructure.Constants.Infrastructure;

namespace PlayBeforeYouDie.Infrastructure.Data.Models;

public class HowLongToBeat
{
    public HowLongToBeat()
    {
        Games = new List<Game>();
    }

    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(ModelsConstants.MainStoryMaxLength)]
    public string MainStory { get; set; } = null!;

    [Required]
    [MaxLength(ModelsConstants.MainPlusSidesMaxLength)]
    public string MainPlusSides { get; set; } = null!;

    [Required]
    [MaxLength(ModelsConstants.HundredPercentCompleteMaxLength)]
    public string HundredPercentComplete { get; set; } = null!;

    [MaxLength(ModelsConstants.SpeedRunMaxLength)]
    public string? SpeedRunAny { get; set; }

    [MaxLength(ModelsConstants.SpeedRunOneHundredPercentMaxLength)]
    public string? SpeedRunOneHundredPercent { get; set; }

    public List<Game> Games { get; set; }

    //[Required]
    //[ForeignKey(nameof(Review))]
    //public int ReviewId { get; set; }
    //public Review Review { get; set; }

}