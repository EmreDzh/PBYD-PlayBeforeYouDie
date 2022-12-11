using Microsoft.EntityFrameworkCore;
using PlayBeforeYouDie.Core.Exceptions;
using PlayBeforeYouDie.Infrastructure.Data.Common;
using PlayBeforeYouDie.Infrastructure.Data;

namespace Microsoft.Extensions.DependencyInjection;

public static class PlayBeforeYouDieApiServiceExtension
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        
        services.AddScoped<IGuard, Guard>();

        return services;
    }

    public static IServiceCollection AddPlayBeforeYouDieRentingDbContext(this IServiceCollection service, IConfiguration config)
    {
        var connectionString = config.GetConnectionString("DefaultConnection");
        service.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(connectionString));
        service.AddScoped<IRepository, Repository>();

        return service;
    }
}