using System.ComponentModel.DataAnnotations;

namespace PlayBeforeYouDie.Infrastructure.Data.Models;

public class SystemRequirement
{
    public SystemRequirement()
    {
        Games = new List<Game>();
    }

    [Key] public int Id { get; set; }

    [Required] public string Os { get; set; } = null!;

    [Required] public string Processor { get; set; } = null!;

    [Required] public string Memory { get; set; } = null!;

    [Required] public string Graphics { get; set; } = null!;

    [Required] public string Network { get; set; } = null!;

    [Required] public string Storage { get; set; } = null!;

    public string? AdditionalNotes { get; set; }

    public List<Game> Games { get; set; }

}