using Microsoft.EntityFrameworkCore;
using PlayBeforeYouDie.Core.Contracts;
using PlayBeforeYouDie.Core.Models.Game;
using PlayBeforeYouDie.Core.Models.Genre;
using PlayBeforeYouDie.Infrastructure.Data;
using PlayBeforeYouDie.Infrastructure.Data.Common;
using PlayBeforeYouDie.Infrastructure.Data.Models;
using PlayBeforeYouDie.Infrastructure.Data.Models.Users;

namespace PlayBeforeYouDie.Core.Service;

public class GameService : IGameService
{
    private readonly IRepository repo;
    private readonly ApplicationDbContext context;

    public GameService(IRepository _repo, ApplicationDbContext _context)
    {
        repo = _repo;
        context = _context;
    }

    public async Task<IEnumerable<GameHomeModel>> GetInitialGames()
    {
        return await repo.AllReadonly<Game>()
            .Where(g => g.IsGameActive)
            .OrderByDescending(g => g.Id)
            .Select(h => new GameHomeModel()
            {
                Id = h.Id,
                GameTitle = h.GameTitle,
                ImageUrl = h.ImageUrl,
                Summary = h.Summary
            })
            .ToListAsync();

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
            .Take(6)
            .ToListAsync();
    }

    public async Task<GamesQueryModel> All(string? genre, string? searchTerm = null, int currentPage = 1, int gamePerPage = 1)
    {
        var result = new GamesQueryModel();
        var games = repo.AllReadonly<Game>()
            .Where(g => g.IsGameActive);

        if (string.IsNullOrEmpty(searchTerm) == false)
        {
            searchTerm = $"%{searchTerm.ToLower()}%";

            games = games
                .Where(h => EF.Functions.Like(h.GameTitle.ToLower(), searchTerm) ||
                            EF.Functions.Like(h.Rating.ToString(), searchTerm));
            
        }

        if (string.IsNullOrEmpty(genre) == false)
        {
            games = games.Where(g => g.Genre.Category == genre);
        }
        

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

    public async Task<IEnumerable<string>> AllGenreNames()
    {
        return await repo.AllReadonly<Genre>()
            .Select(g => g.Category)
            .Distinct()
            .ToListAsync();
    }

    public async Task<IEnumerable<GenreModel>> AllGenres()
    {
        return await repo.AllReadonly<Genre>()
            .OrderBy(g => g.Category)
            .Select(c => new GenreModel()
            {
                Id = c.Id,
                Category = c.Category
            })
            .ToListAsync();
    }

    public async Task<bool> Exists(int id)
    {
        return await repo.AllReadonly<Game>()
            .AnyAsync(g => g.Id == id && g.IsGameActive);
    }

    
    public async Task AddGameToMyLibrary(int id, string userId)
    {
        var user = await context.Users
            .Where(u => u.Id == userId)
            .Include(u => u.ApplicationUserGames)
            .FirstOrDefaultAsync();

        if (user == null)
        {
            throw new ArgumentException("Invalid user Id");
        }

        var game = await repo.GetByIdAsync<Game>(id);

        if (game == null)
        {
            throw new ArgumentException("Invalid Game Id");
        }

        if (!user.ApplicationUserGames.Any(g => g.GameId == id))
        {
            user.ApplicationUserGames.Add(new ApplicationUserGame()
            {
                GameId = game.Id,
                ApplicationUserId = user.Id,
                Game = game,
                ApplicationUser = user
            });

            try
            {
                await repo.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new ApplicationException("Database is down or failed to submit the info", e);
            }
        }
    }

    public async Task AddGame(AddGameModel model)
    {
        

        var game = new Game()
        {
            Id = model.Id,
            GameTitle = model.GameTitle,
            ImageUrl = model.ImageUrl,
            Rating = model.Rating,
            Summary = model.Summary,
            GenreId = model.GenreId,
            SystemRequirement = new SystemRequirement()
            {
                Os = model.Os,
                Graphics = model.Graphics,
                Memory = model.Memory,
                AdditionalNotes = model.AdditionalNotes,
                Network = model.Network,
                Processor = model.Processor,
                Storage = model.Storage
            },
            HowLongToBeat = new List<HowLongToBeat>()
            {
                new HowLongToBeat()
                {

                    GameId = model.Id,
                    MainStory = model.MainStory,
                    HundredPercentComplete = model.HundredPercentComplete,
                    MainPlusSides = model.MainPlusSides,
                    SpeedRunAny = model.SpeedRunAny,
                    SpeedRunOneHundredPercent = model.SpeedRunOneHundredPercent
                }
            },
            Mods = new List<Mod>()
            {
                new Mod()
                {
                    GameId = model.Id,
                    Description = model.Description,
                    DownloadModLink = model.DownloadModLink,
                    ModName = model.ModName,
                    ModPicture = new ModPicture()
                    {
                        ModImageOne = model.ModImageOne
                    }
                }
            }
            
        };

        try
        {
            await repo.AddAsync(game);
            await repo.SaveChangesAsync();
        }
        catch (Exception e)
        {
            throw new ApplicationException("Database is down or failed to save the info", e);
        }

    }


    public async Task<IEnumerable<GameModel>> GetMyLibraryAsync(string userId)
    {
        var user = await context.Users
            .Where(u => u.Id == userId)
            .Include(u => u.ApplicationUserGames)
            .ThenInclude(gm => gm.Game)
            .FirstOrDefaultAsync();

        if (user == null)
        {
            throw new ArgumentException("Invalid user Id");
        }

        return user.ApplicationUserGames
            .Select(g => new GameModel()
            {
                Id = g.Game.Id,
                GameTitle = g.Game.GameTitle,
                ImageUrl = g.Game.ImageUrl,
                Rating = g.Game.Rating,
                Summary = g.Game.Summary

            });
    }

    public async Task RemoveGameFromLibrary(int gameId, string userId)
    {
        var user = await context.Users
            .Where(u => u.Id == userId)
            .Include(u => u.ApplicationUserGames)
            .FirstOrDefaultAsync();

        if (user == null)
        {
            throw new ArgumentException("Invalid user Id");
        }

        var game = user.ApplicationUserGames.FirstOrDefault(g => g.GameId == gameId);

        if (game != null)
        {
            try
            {
                user.ApplicationUserGames.Remove(game);

                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new ApplicationException("Database is down or failed to submit the info", e);
            }
        }


    }

    public async Task<GameServiceModel> DeleteGameById(int gameId)
    {
        return await repo.AllReadonly<Game>()
            .Where(g => g.IsGameActive)
            .Where(g => g.Id == gameId)
            .Select(g => new GameServiceModel()
            {
                Id = g.Id,
                GameTitle = g.GameTitle,
                ImageUrl = g.ImageUrl,
                Rating = g.Rating,
                Summary = g.Summary

            })
            .FirstAsync();
    }

    public async Task DeleteGame(int id)
    {
        var game = await repo.GetByIdAsync<Game>(id);
        
        game.IsGameActive = false;

        try
        {
            await repo.SaveChangesAsync();
        }
        catch (Exception e)
        {
            throw new ApplicationException("Database is down or failed to remove the game", e);
        }
    }
}