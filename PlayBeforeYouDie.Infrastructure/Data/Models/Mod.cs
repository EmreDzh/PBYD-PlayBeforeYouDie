using System.ComponentModel.DataAnnotations;
using PlayBeforeYouDie.Infrastructure.Constants.Infrastructure;

namespace PlayBeforeYouDie.Infrastructure.Data.Models;

public class Mod
{
    public Mod()
    {
        Games = new List<Game>();
    }

    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(ModelsConstants.ModNameMaxLength)]
    public string ModName { get; set; } = null!;

    [Required]
    [MaxLength(ModelsConstants.ModDescriptionMaxLength)]
    public string Description { get; set; } = null!;

    [Required] 
    public string ModImage { get; set; } = null!;

    [Required] 
    public string DownloadModLink { get; set; } = null!;

    public List<Game> Games { get; set; } 
}