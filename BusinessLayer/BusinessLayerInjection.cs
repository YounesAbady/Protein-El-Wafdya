using DataAccessLayer;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLayer
{
    public static class BusinessLayerInjection
    {
        public static void ConfigureBL(this IServiceCollection services, string connectionString)
        {
            services.ConfigureDAL(connectionString);
        }
    }
}
