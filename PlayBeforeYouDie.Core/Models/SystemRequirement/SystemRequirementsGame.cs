namespace PlayBeforeYouDie.Core.Models.SystemRequirement;

public class SystemRequirementsGame
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