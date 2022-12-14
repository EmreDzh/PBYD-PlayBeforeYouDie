using PlayBeforeYouDie.Infrastructure.Constants.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace PBYD___PlayBeforeYouDie.Areas.Admin.Models.Mod;

public class ModDeleteViewModel
{
    public int Id { get; set; }

    public string DownloadModLink { get; set; } = null!;
    
    public string ModName { get; set; } = null!;

    public string Description { get; set; } = null!;
}