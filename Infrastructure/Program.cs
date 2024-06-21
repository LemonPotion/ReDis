using Infrastructure.Interfaces;
using Infrastructure.Settings;
using Refit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();

app.MapControllers();


app.Run();