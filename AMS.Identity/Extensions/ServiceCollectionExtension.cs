using AMS.Identity.Services.Contracts;
using AMS.Identity.Services;

namespace AMS.Identity.Extensions;

public static class ServiceCollectionExtension
{
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<IAccountService, AccountService>();
    }
}