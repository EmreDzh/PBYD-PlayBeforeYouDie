using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PlayBeforeYouDie.Infrastructure.Constants.Infrastructure;

namespace PlayBeforeYouDie.Infrastructure.Data.Models;

public class Game
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(ModelsConstants.GameTitleMaxLength)]
    public string GameTitle { get; set; } = null!;

    [Required]
    [MaxLength(ModelsConstants.SummaryMaxLength)]
    public string Summary { get; set; } = null!;

    [Required]
    public string ImageUrl { get; set; } = null!;

    [Required]
    public decimal Rating { get; set; }

    [Required]
    [ForeignKey(nameof(Genre))]
    public int GenreId { get; set; }
    public Genre Genre { get; set; }

    [Required]
    [ForeignKey(nameof(SystemRequirement))]
    public int SystemRequirementId { get; set; }
    public SystemRequirement SystemRequirement { get; set; }

    [Required]
    [ForeignKey(nameof(HowLongToBeat))] 
    public int HowLongToBeatId { get; set; }
    public HowLongToBeat HowLongToBeat { get; set; }

    [Required]
    [ForeignKey(nameof(Mod))]
    public int ModId { get; set; }
    public Mod Mod { get; set; }

    public bool IsGameActive { get; set; } = true;

}