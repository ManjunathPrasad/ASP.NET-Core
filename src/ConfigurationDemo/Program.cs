using Microsoft.Extensions.Options;

namespace ConfigurationDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.Configure<MySettings>(builder.Configuration.GetSection("MySettings"));

            var app = builder.Build();

            //app.MapGet("/settings", (IOptions<MySettings> options) =>
            //{
            //    var settings1 = options.Value.Settings1;
            //    var settings2 = options.Value.Settings2;

            //    return $"Settings1: {settings1}, Settings2: {settings2}";
            //});
            app.MapControllers();

            app.Run();
        }
    }
}
