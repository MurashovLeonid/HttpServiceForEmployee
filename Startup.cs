
using xxXXXxxx.xxXXXxxx.ru.Context;
using Microsoft.EntityFrameworkCore;


namespace xxXXXxxx.xxXXXxxx.ru
{
    public static class Startup
    {
        public static WebApplication InitializeApp(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            ConfigureServices(builder);
            var app = builder.Build();
            Configure(app);
            return app;
        }
        private static void ConfigureServices(WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<SupportWebContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("SupportWeb"));

            });

        }

        private static void Configure(WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {

            }
          
            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();           
        }
    }
}
