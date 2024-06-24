using Infrastructure.Interfaces;
using Infrastructure.Settings;
using Refit;

namespace Infrastructure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddControllers();
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                            .AllowAnyMethod()
                            .AllowAnyHeader();
                    });
            });

            builder.Services.Configure<DiscordSettings>(builder.Configuration.GetSection(nameof(DiscordSettings)));
            var discordSettings =builder.Configuration.GetSection(nameof(DiscordSettings)).Get<DiscordSettings>();
            
            builder.Services.AddSingleton(RestService.For<IAuthorization>(discordSettings.ApiEndpoint));
            builder.Services.AddSingleton(RestService.For<IGuildApi>(discordSettings.ApiEndpoint));
            builder.Services.AddSingleton(RestService.For<IChannelApi>(discordSettings.ApiEndpoint));
            
            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseRouting();

            app.MapControllers();


            app.Run();
        }
    }
}