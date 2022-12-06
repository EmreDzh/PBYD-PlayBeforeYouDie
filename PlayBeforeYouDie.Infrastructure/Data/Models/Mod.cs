using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
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

    public string? DownloadModLink { get; set; } 

    public string? YoutubeVideoModComparison { get; set; }

    [Required]
    [ForeignKey(nameof(ModPicture))]
    public int ModPictureId { get; set; }

    public ModPicture ModPicture { get; set; }

    public List<Game> Games { get; set; } 
}