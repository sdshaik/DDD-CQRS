using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Identity.Web;

namespace HackerRank.Monitoring.Api.Authentication
{
    internal static class AuthExtensions
    {
        public static void ConfigureAuthentication(this IServiceCollection services, IConfigurationRoot configuration)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddMicrosoftIdentityWebApi(configuration.GetSection("AzureAd"));
        }

        public static void EnableAuthentication(this WebApplication app)
        {
            app.UseAuthentication();
            app.UseAuthorization();
        }
    }
}
