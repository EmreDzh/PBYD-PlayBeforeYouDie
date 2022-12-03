using PlayBeforeYouDie.Core.Models.HowLongToBeat;

namespace PlayBeforeYouDie.Core.Contracts;

public interface IHowLongToBeatService
{
    Task<HowLongToBeatModel> GameHowLongToBeatById(int id);

    Task<int> SubmitPlayTime(HowLongToBeatModel model, int gameId);

    Task<int> GetHowLongToBeatId(int id);
}