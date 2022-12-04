using PlayBeforeYouDie.Core.Models.SystemRequirement;

namespace PlayBeforeYouDie.Core.Contracts;

public interface ISystemRequirementsService
{
    Task<SystemRequirementsModel> SystemRequirementsGameById(int id);
}