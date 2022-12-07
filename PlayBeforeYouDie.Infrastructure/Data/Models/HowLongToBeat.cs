using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PlayBeforeYouDie.Infrastructure.Constants.Infrastructure;

namespace PlayBeforeYouDie.Infrastructure.Data.Models;

public class HowLongToBeat
{
    
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

    
    [ForeignKey(nameof(Game))]
    public int GameId { get; set; }
    public Game Game { get; set; }

    //[Required]
    //[ForeignKey(nameof(Review))]
    //public int ReviewId { get; set; }
    //public Review Review { get; set; }

}