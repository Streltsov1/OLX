using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Cors.Infrastructure;
using OLX.Services;

namespace OLX.Helpers
{
    public static class ServiceExtensions
    {
        public static void AddFavoriteService(this IServiceCollection services)
        {
            services.AddScoped<IFavoriteService, FavoriteService>();
        }
    }
}
