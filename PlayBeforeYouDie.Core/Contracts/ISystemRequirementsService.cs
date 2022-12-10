using PlayBeforeYouDie.Core.Models.SystemRequirement;


namespace PlayBeforeYouDie.Core.Contracts;

public interface ISystemRequirementsService
{
    Task<SystemRequirementsModel> SystemRequirementsGameById(int id);

    Task<SystemRequirementsDetails> SystemRequirementsDetailsById(int id);

    Task Edit(int systemRequirementsId, SystemRequirementsModel model);

    Task<bool> SystemRequirementsExists(int systemRequirementsId);

    Task<IEnumerable<SystemRequirementsGame>> AllSystemRequirements();

    
}