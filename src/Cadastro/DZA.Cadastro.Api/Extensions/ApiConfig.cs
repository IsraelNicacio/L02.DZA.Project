namespace DZA.Cadastro.Api.Extensions;

public static class ApiConfig
{
    private const string AllowAllPolicy = "AllowAll";

    public static void AddApiConfiguration(this IServiceCollection services)
    {
        services
            .AddCors(options =>
            {
                options.AddPolicy(AllowAllPolicy,
                    builder => builder
                    .WithOrigins("http://localhost:8082/Swagger/index.html", "http://localhost:8082")
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    );
            });
    }

    public static void UseApiConfiguration(this WebApplication app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment() || env.IsEnvironment("Stage") || env.IsEnvironment("Docker"))
            app.UseDeveloperExceptionPage();

        if (app.Configuration["USE_HTTOPS_REDIRECTION"] == "true")
            app.UseHttpsRedirection();

        app.UseRouting();
        app.UseCors(AllowAllPolicy);
        app.UseAuthorization();
        app.MapControllers();
    }
}
