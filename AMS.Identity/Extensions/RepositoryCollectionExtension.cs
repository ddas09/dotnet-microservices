using AMS.Common.DAL.Repositories;
using AMS.Common.DAL.Contracts;
using AMS.Identity.Data;

namespace AMS.Identity.Extensions;

public static class RepositoryCollectionExtension
{
    public static void RegisterRepositories(this IServiceCollection services)
    {
        services.AddScoped<IUserRepository, UserRepository<IdentityServerDBContext>>();
    }
}