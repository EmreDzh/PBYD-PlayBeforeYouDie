using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PlayBeforeYouDie.Infrastructure.Constants.Infrastructure;
using PlayBeforeYouDie.Infrastructure.Data.Models.Users;

namespace PlayBeforeYouDie.Infrastructure.Data.Models;

public class Game
{
    public Game()
    {
        HowLongToBeat = new List<HowLongToBeat>();
        Mods = new List<Mod>();
        ApplicationUserGames = new List<ApplicationUserGame>();
    }

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

    public List<HowLongToBeat> HowLongToBeat { get; set; }

    public List<Mod> Mods { get; set; }

    public List<ApplicationUserGame> ApplicationUserGames { get; set; }


    [Required]
    [ForeignKey(nameof(Genre))]
    public int GenreId { get; set; }
    public Genre Genre { get; set; }

    [Required]
    [ForeignKey(nameof(SystemRequirement))]
    public int SystemRequirementId { get; set; }
    public SystemRequirement SystemRequirement { get; set; }
    
    public bool IsGameActive { get; set; } = true;

}