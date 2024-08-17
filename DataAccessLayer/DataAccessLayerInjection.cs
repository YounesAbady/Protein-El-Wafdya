using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccessLayer
{
    public static class DataAccessLayerInjection
    {
        public static void ConfigureDAL(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<Context>(options => options.UseSqlServer(connectionString, b => b.MigrationsAssembly("DataAccessLayer")));
        }
    }
}
