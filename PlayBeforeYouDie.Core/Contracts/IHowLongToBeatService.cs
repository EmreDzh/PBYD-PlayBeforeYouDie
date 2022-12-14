using PlayBeforeYouDie.Core.Models.Game;
using PlayBeforeYouDie.Core.Models.HowLongToBeat;

namespace PlayBeforeYouDie.Core.Contracts;

public interface IHowLongToBeatService
{
    Task<List<HowLongToBeatModel>> GameHowLongToBeatById(int id);

    Task SubmitPlayTime(HowLongToBeatModel model);

    Task<bool> Exists(int id);

    Task<HowLongToBeatModel> DeleteHowLongToBeatById(int id);

    Task DeleteHowLongToBeat(int id);




}