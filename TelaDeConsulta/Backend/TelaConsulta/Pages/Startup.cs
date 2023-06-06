using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // Configurar o CORS
        services.AddCors(options =>
        {
            options.AddPolicy("AllowOrigin", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            });
        });

        // Restante das configurações do serviço
    }

    public void Configure(IApplicationBuilder app)
    {
        // Habilitar o CORS
        app.UseCors("AllowOrigin");

        // Restante das configurações do aplicativo
    }
}
