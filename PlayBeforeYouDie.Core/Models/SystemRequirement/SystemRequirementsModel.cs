using PlayBeforeYouDie.Infrastructure.Constants.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace PlayBeforeYouDie.Core.Models.SystemRequirement;

public class SystemRequirementsModel
{
    
    public int Id { get; set; }

    [StringLength(ModelsConstants.GameTitleMaxLength, MinimumLength = ModelsConstants.GameTitleMinLength)]
    public string? GamesTitle { get; set; }

    public string? ImageUrl { get; set; }
    
    [Required]
    [StringLength(ModelsConstants.OsMaxLength, MinimumLength = ModelsConstants.OsMinLength)]
    public string Os { get; set; } = null!;

    [Required]
    [StringLength(ModelsConstants.ProcessorMaxLength, MinimumLength = ModelsConstants.ProcessorMinLength)]
    public string Processor { get; set; } = null!;

    [Required]
    [StringLength(ModelsConstants.MemoryMaxLength, MinimumLength = ModelsConstants.MemoryMinLength)]
    public string Memory { get; set; } = null!;

    [Required]
    [StringLength(ModelsConstants.GraphicsMaxLength, MinimumLength = ModelsConstants.GraphicsMinLength)]
    public string Graphics { get; set; } = null!;

    [Required]
    [StringLength(ModelsConstants.NetworkMaxLength, MinimumLength = ModelsConstants.NetworkMinLength)]
    public string Network { get; set; } = null!;

    [Required]
    [StringLength(ModelsConstants.StorageMaxLength, MinimumLength = ModelsConstants.StorageMinLength)]
    public string Storage { get; set; } = null!;

    [StringLength(ModelsConstants.AdditionalNotesMaxLength, MinimumLength = ModelsConstants.AdditionalNotesMinLength)]
    [Display(Name = "Additional Notes for games Requirements")]
    public string? AdditionalNotes { get; set; }

    
}