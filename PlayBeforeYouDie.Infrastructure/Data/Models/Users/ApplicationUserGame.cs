using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlayBeforeYouDie.Infrastructure.Data.Models.Users;

public class ApplicationUserGame
{
    [ForeignKey(nameof(ApplicationUser))]
    [Required]
    public string ApplicationUserId { get; set; }

    public ApplicationUser ApplicationUser { get; set; }


    [ForeignKey(nameof(Game))]
    [Required]
    public int GameId { get; set; }

    public Game Game { get; set; }
}