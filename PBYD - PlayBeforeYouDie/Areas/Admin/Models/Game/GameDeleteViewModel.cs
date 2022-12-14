namespace PBYD___PlayBeforeYouDie.Areas.Admin.Models.Game;

public class GameDeleteViewModel
{
    public int Id { get; set; }

    public string GameTitle { get; set; }

    public string ImageUrl { get; set; }

    public string Description { get; set; }

    public decimal Rating { get; set; }
}