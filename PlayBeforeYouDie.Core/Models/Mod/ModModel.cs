using PlayBeforeYouDie.Infrastructure.Constants.Infrastructure;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using PlayBeforeYouDie.Infrastructure.Data.Models;

namespace PlayBeforeYouDie.Core.Models.Mod;

public class ModModel
{
    public int Id { get; set; }

    [StringLength(ModelsConstants.GameTitleMaxLength, MinimumLength = ModelsConstants.GameTitleMinLength)]
    public string? GamesTitle { get; set; }

    [Required]
    [StringLength(ModelsConstants.ModNameMaxLength, MinimumLength = ModelsConstants.ModNameMinxLength)]
    public string ModName { get; set; } = null!;

    [Required]
    [StringLength(ModelsConstants.ModDescriptionMaxLength, MinimumLength = ModelsConstants.ModDescriptionMinLength)]
    public string Description { get; set; } = null!;
    
    [Required]
    public string DownloadModLink { get; set; } = null!;

    public string? YoutubeVideoModComparison { get; set; }

    public int ModImageId { get; set; }

    [Required] 
    public string ModImageOne { get; set; } = null!;

    public string? ModImageTwo { get; set; }

    public string? ModImageThree { get; set; }

    public string? ModImageFour { get; set; }

    public int GameId { get; set; }
}