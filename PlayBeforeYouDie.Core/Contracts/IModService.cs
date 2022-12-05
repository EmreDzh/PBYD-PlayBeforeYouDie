using PlayBeforeYouDie.Core.Models.Mod;
using PlayBeforeYouDie.Core.Models.SystemRequirement;

namespace PlayBeforeYouDie.Core.Contracts;

public interface IModService
{
    Task<ModModel> ModsByGameById(int id);
}