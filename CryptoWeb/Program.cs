using CryptoWeb.Services;
using Microsoft.OpenApi.Models;

namespace CryptoWeb
{
    public class Program
    {
        public static void Main()
        {
            var builder = WebApplication.CreateBuilder();

            builder.Services.AddScoped<ICryptoService, CryptService>();
            builder.Services.AddScoped<IKeyService, KeyService>();
            builder.Services.AddControllers();
            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "My Crypt API", Version = "v1" });
            });

            var app = builder.Build();

            app.UseSwagger();

            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "My Crypt API V1");
                options.RoutePrefix = string.Empty;
            });

            app.MapControllers();
            app.Run();
        }
    }
}