using Microsoft.OpenApi.Models;

namespace HackerRank.Monitoring.Api.Extensions
{
    internal static class SwaggerExtensions
    {
        public static void AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "HackerRank.Monitoring.Api(Dawood_Assessment)",
                    Version = "v1"
                });
                c.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Type = SecuritySchemeType.OAuth2,
                    Flows = new OpenApiOAuthFlows()
                    {
                        Implicit = new OpenApiOAuthFlow()
                        {
                            AuthorizationUrl = new Uri("https://login.microsoftonline.com/8f6bd982-92c3-4de0-985d-0e287c55e379/oauth2/v2.0/authorize"),
                            TokenUrl = new Uri("https://login.microsoftonline.com/8f6bd982-92c3-4de0-985d-0e287c55e379/oauth2/v2.0/token"),
                            Scopes = new Dictionary<string, string>
                {
                        {
                            "api://88ff2f97-5265-4064-aeab-3a12d394e969/DawoodAssessment",
                            ""
                        }
                }
                        }
                    }
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement() {
            {
                    new OpenApiSecurityScheme
                {
                      Reference = new OpenApiReference
            {
                       Type = ReferenceType.SecurityScheme,
                        Id = "oauth2"
            },
                Scheme = "oauth2",
                Name = "oauth2",
                In = ParameterLocation.Header
            },
                 new List < string > ()
                 }});
            });
        }
        public static void EnableSwagger(this WebApplication app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "AuthDemo v1"); c.OAuthClientId("88ff2f97-5265-4064-aeab-3a12d394e969");
                c.OAuthClientSecret("C398Q~DOZsVnjEuEe8MPca3opNBF5flIJkavab4A");
                c.OAuthUseBasicAuthenticationWithAccessCodeGrant();
            });
        }
    }
}
