namespace DZA.Cadastro.Api.Extensions
{
    public static class SwaggerConfig
    {
        public static void UseSwaggerConfiguratio(this WebApplication app)
        {
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment() || app.Environment.IsEnvironment("Stage") || app.Environment.IsEnvironment("Docker"))
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
        }
    }
}
