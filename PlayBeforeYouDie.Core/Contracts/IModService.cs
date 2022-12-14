using PlayBeforeYouDie.Core.Models.HowLongToBeat;
using PlayBeforeYouDie.Core.Models.Mod;
using PlayBeforeYouDie.Core.Models.SystemRequirement;

namespace PlayBeforeYouDie.Core.Contracts;

public interface IModService
{
    
    Task<List<ModModel>> ModsByGameById(int id);

    Task SubmitMod(ModModel model);

    Task<bool> Exists(int id);

    Task<ModModel> DeleteModById(int id);

    Task DeleteMod(int id);
}