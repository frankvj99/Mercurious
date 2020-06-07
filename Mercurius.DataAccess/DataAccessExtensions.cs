using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace Mercurius.DataAccess
{
    public static class DataAccessExtensions
    {
        public static void UseMercuriousDataAccess(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<MercuriusContext>(opt =>
              opt.UseSqlServer(connectionString));
        }
    }
}
