using PlayBeforeYouDie.Infrastructure.Constants.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace PlayBeforeYouDie.Core.Models.SystemRequirement;

public class SystemRequirementsDetails
{
    public int Id { get; set; }
    
    public string Os { get; set; } = null!;

    public string Processor { get; set; } = null!;

    public string Memory { get; set; } = null!;
    
    public string Graphics { get; set; } = null!;
    
    public string Network { get; set; } = null!;

    public string Storage { get; set; } = null!;

    public string? AdditionalNotes { get; set; }
}