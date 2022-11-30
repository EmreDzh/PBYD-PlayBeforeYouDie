﻿using PlayBeforeYouDie.Core.Models.Game;
using System.ComponentModel.DataAnnotations;

namespace PBYD___PlayBeforeYouDie.Models;

public class AllGamesQueryModel
{
    public const int HousesPerPage = 6;

    public int CurrentPage { get; init; } = 1;

    public int TotalGamesCount { get; set; }

    [Display(Name = "Search games name or rating")]
    public string? SearchGame { get; init; }

    public IEnumerable<GameServiceModel> Games { get; set; } = new List<GameServiceModel>();
}