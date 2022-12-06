using System.ComponentModel.DataAnnotations;

namespace PlayBeforeYouDie.Infrastructure.Data.Models;

public class ModPicture
{
    public ModPicture()
    {
        Mods = new List<Mod>();
    }

    [Key]
    public int Id { get; set; }

    [Required] 
    public string ModImageOne { get; set; } = null!;

    public string? ModImageTwo { get; set; } = null!;

    public string? ModImageThree { get; set; } = null!;

    
    public string? ModImageFour { get; set; }

    public List<Mod> Mods { get; set; }
}