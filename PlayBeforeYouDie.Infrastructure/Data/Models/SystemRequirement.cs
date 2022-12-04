using System.ComponentModel.DataAnnotations;
using PlayBeforeYouDie.Infrastructure.Constants.Infrastructure;

namespace PlayBeforeYouDie.Infrastructure.Data.Models;

public class SystemRequirement
{
    public SystemRequirement()
    {
        Games = new List<Game>();
    }

    [Key] 
    public int Id { get; set; }

    [Required]
    [MaxLength(ModelsConstants.OsMaxLength)]
    public string Os { get; set; } = null!;

    [Required]
    [MaxLength(ModelsConstants.ProcessorMaxLength)]
    public string Processor { get; set; } = null!;

    [Required]
    [MaxLength(ModelsConstants.MemoryMaxLength)]
    public string Memory { get; set; } = null!;

    [Required]
    [MaxLength(ModelsConstants.GraphicsMaxLength)]
    public string Graphics { get; set; } = null!;

    [Required]
    [MaxLength(ModelsConstants.NetworkMaxLength)]
    public string Network { get; set; } = null!;

    [Required]
    [MaxLength(ModelsConstants.StorageMaxLength)]
    public string Storage { get; set; } = null!;

    [MaxLength(ModelsConstants.AdditionalNotesMaxLength)]
    public string? AdditionalNotes { get; set; }

    public List<Game> Games { get; set; }

}