namespace DZA.Cadastro.Api.Extensions;

public static class CorsConfig
{
    private const string AllowAllPolicy = "AllowAll";

    public static void AddCorsServices(this IServiceCollection services )
    {
        services
            .AddCors(options =>
            {
                options.AddPolicy(AllowAllPolicy,
                    builder => builder
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials()
                    );
            });
    }

    public static void ApplyCorsConfig(this WebApplication app)
    {
        app.UseCors(AllowAllPolicy);
    }
}
