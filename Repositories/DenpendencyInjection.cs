using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace Repositories
{
    public static class DenpendencyInjection
    {

        public static IServiceCollection AddInfrastructuresService(this IServiceCollection services, string databaseConnection)
        {
            services.AddDbContext<DataContext>(option =>
            {
                option.UseSqlServer(databaseConnection);
            });
            return services;
        }
    }
}
