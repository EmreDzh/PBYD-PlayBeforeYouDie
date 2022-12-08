using PlayBeforeYouDie.Infrastructure.Constants.Infrastructure;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using PlayBeforeYouDie.Infrastructure.Data.Models;

namespace PlayBeforeYouDie.Core.Models.Mod;

public class ModModel
{
    public int Id { get; set; }

    [StringLength(ModelsConstants.GameTitleMaxLength, MinimumLength = ModelsConstants.GameTitleMinLength)]
    [Display(Name = "Games Title")]
    public string? GamesTitle { get; set; }

    [Required]
    [StringLength(ModelsConstants.ModNameMaxLength, MinimumLength = ModelsConstants.ModNameMinxLength)]
    [Display(Name = "Mod Name")]
    public string ModName { get; set; } = null!;

    [Required]
    [StringLength(ModelsConstants.ModDescriptionMaxLength, MinimumLength = ModelsConstants.ModDescriptionMinLength)]
    [Display(Name = "Description for the Mod")]
    public string Description { get; set; } = null!;
    
    [Required]
    [Display(Name = "Link to download the Mod")]
    public string DownloadModLink { get; set; } = null!;

    [Display(Name = "Youtube Video Link")]
    public string? YoutubeVideoModComparison { get; set; }

    public int ModImageId { get; set; }

    [Required]
    [Display(Name = "1st Mod Image")]
    public string ModImageOne { get; set; } = null!;

    [Display(Name = "2nd Mod Image")]
    public string? ModImageTwo { get; set; }

    [Display(Name = "3rd Mod Image")]
    public string? ModImageThree { get; set; }

    [Display(Name = "4th Mod Image")]
    public string? ModImageFour { get; set; }

    public int GameId { get; set; }
}