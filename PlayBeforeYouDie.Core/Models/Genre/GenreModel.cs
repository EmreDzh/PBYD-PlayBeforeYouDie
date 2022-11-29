using PlayBeforeYouDie.Infrastructure.Constants.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace PlayBeforeYouDie.Core.Models.Genre;

public class GenreModel
{
    public int Id { get; set; }

    [Required]
    [StringLength(ModelsConstants.CategoryMaxLength, MinimumLength = ModelsConstants.CategoryMinLength)]
    public string Category { get; set; } = null!;
}