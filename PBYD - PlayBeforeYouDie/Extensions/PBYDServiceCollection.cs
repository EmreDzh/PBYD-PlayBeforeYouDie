using PlayBeforeYouDie.Core.Exceptions;
using PlayBeforeYouDie.Infrastructure.Data.Common;

namespace Microsoft.Extensions.DependencyInjection;

public static class PBYDServiceCollection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IGuard, Guard>();

        return services;
    }
}