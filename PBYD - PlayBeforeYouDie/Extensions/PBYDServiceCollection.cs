using PlayBeforeYouDie.Core.Contracts;
using PlayBeforeYouDie.Core.Exceptions;
using PlayBeforeYouDie.Core.Service;
using PlayBeforeYouDie.Infrastructure.Data.Common;

namespace Microsoft.Extensions.DependencyInjection;

public static class PBYDServiceCollection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IGuard, Guard>();
        services.AddScoped<IRepository, Repository>();
       
        services.AddScoped<IGameService, GameService>();
        services.AddScoped<IHowLongToBeatService, HowLongToBeatService>();
        services.AddScoped<ISystemRequirementsService, SystemRequirementsService>();
        services.AddScoped<IModService, ModService>();

        return services;
    }
}