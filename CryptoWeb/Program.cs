
namespace CryptoWeb
{
    public class Program
    {
        public static void Main()
        {
            var builder = WebApplication.CreateBuilder();

            builder.Services.AddOpenApi();

            var app = builder.Build();

            app.MapOpenApi();

            app.MapGet("/", () => "Hello world!");

            app.Run();
        }
    }
}
