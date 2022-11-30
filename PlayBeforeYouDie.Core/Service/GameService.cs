﻿using Microsoft.EntityFrameworkCore;
using PlayBeforeYouDie.Core.Contracts;
using PlayBeforeYouDie.Core.Models.Game;
using PlayBeforeYouDie.Infrastructure.Data.Common;
using PlayBeforeYouDie.Infrastructure.Data.Models;

namespace PlayBeforeYouDie.Core.Service;

public class GameService : IGameService
{
    private readonly IRepository repo;

    public GameService(IRepository _repo)
    {
        repo = _repo;

    }

    public async Task<IEnumerable<GameServiceModel>> GetAll()
    {
        return await repo.AllReadonly<Game>()
            .Where(g => g.IsGameActive)
            .OrderByDescending(g => g.Id)
            .Select(g => new GameServiceModel()
            {
                GameTitle = g.GameTitle,
                Summary = g.Summary,
                Id = g.Id,
                ImageUrl = g.ImageUrl,
                Rating = g.Rating
            })
            .Take(3)
            .ToListAsync();
    }

    public async Task<GamesQueryModel> All(int currentPage = 1, int gamePerPage = 1)
    {
        var result = new GamesQueryModel();
        var games = repo.AllReadonly<Game>()
            .Where(g => g.IsGameActive);

        result.Games = await games
            .Skip((currentPage - 1) * gamePerPage)
            .Take(gamePerPage)
            .Select(g => new GameServiceModel()
            {
                GameTitle = g.GameTitle,
                Id = g.Id,
                ImageUrl = g.ImageUrl,
                Summary = g.Summary,
                Rating = g.Rating
            }).ToListAsync();

        result.TotalGamesCount = await games.CountAsync();

        return result;

    }
}