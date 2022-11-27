using System.ComponentModel.DataAnnotations;

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
    public string MainStory { get; set; } = null!;

    [Required] 
    public string MainPlusSides { get; set; } = null!;

    [Required] 
    public string HundredPercentComplete { get; set; } = null!;

    public string? SpeedRunAny { get; set; }

    public string? SpeedRunOneHundredPercent { get; set; }

    public List<Game> Games { get; set; }

    //[Required]
    //[ForeignKey(nameof(Review))]
    //public int ReviewId { get; set; }
    //public Review Review { get; set; }

}