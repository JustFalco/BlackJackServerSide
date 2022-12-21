using System.Runtime.CompilerServices;
using System.Text;
using BlackJackServer;
using DatabaseLayer.DAL.Contexts;
using DatabaseLayer.DAL.DomainModels;
using DatabaseLayer.Repositories;
using GameLibrary.Controllers;
using Services.Hubs;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.SignalR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var configuration = builder.Configuration;

var jwtConfig = configuration.GetSection("JWT");
var secretKey = jwtConfig["secret"];

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        builder =>
        {
            builder.WithOrigins("http://127.0.0.1:5173")
                .AllowAnyHeader()
                .WithMethods("GET", "POST")
                .AllowCredentials();
        });
});


//TODO remove
builder.Services.AddCors(options =>
{
    options.AddPolicy("post", policy =>
    {
        policy.AllowCredentials().AllowAnyHeader().AllowAnyMethod();
    });
});

builder.Services.AddSignalR();
builder.Services.AddTransient<IGameController,GameController>();
builder.Services.AddTransient<IPlayerController, PlayerController>();
builder.Services.AddTransient<IPlayerRepository, PlayerRepository>();
builder.Services.AddTransient<GameHub>();
builder.Services.AddTransient<IGameRepository, GameRepository>();
builder.Services.AddTransient<ICardRepository, CardRepository>();
builder.Services.AddTransient<ICardDeckRepository, CardDeckRepository>();
/*builder.Services.AddDbContext<GameContext>(
    options => options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection")))
    );*/


builder.Services.AddDbContext<PlayerContext>(
    options => options.UseSqlServer("Server=.; Database=BlackJackUsers; Trusted_Connection=True; trustServerCertificate=true")
);

/*builder.Services.AddDbContext<GameContext>();*/
builder.Services.AddMemoryCache();

builder.Services.AddIdentity<Player, IdentityRole<int>>().AddEntityFrameworkStores<PlayerContext>().AddDefaultTokenProviders();
builder.Services.AddSingleton<IUserIdProvider, EmailBasedUserIdProvider>();

builder.Services.AddControllers();

//TODO alleen voor development
builder.Services.Configure<IdentityOptions>(opts =>
{
    //No requirements for password (pls only use for testing purposes)
    opts.Password.RequireDigit = false;
    opts.Password.RequireLowercase = false;
    opts.Password.RequireUppercase = false;
    opts.Password.RequireNonAlphanumeric = false;
    opts.Password.RequireUppercase = false;
    opts.Password.RequiredLength = 1;
    opts.Password.RequiredUniqueChars = 0;
});

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = jwtConfig["validIssuer"],
        ValidAudience = jwtConfig["validAudience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
    };

    options.Events = new JwtBearerEvents
    {
        OnMessageReceived = context =>
        {
            var accessToken = context.Request.Query["access_token"];

            // If the request is for our hub...
            var path = context.HttpContext.Request.Path;
            if (!string.IsNullOrEmpty(accessToken) &&
                (path.StartsWithSegments("/gameHub")))
            {
                // Read the token out of the query string
                context.Token = accessToken;
            }

            return Task.CompletedTask;
        }
    };
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.MapControllers();
app.UseCors();
//TODO remove
app.UseCors("post");
app.UseRouting();
app.UseAuthorization();
app.UseAuthentication();
app.MapHub<GameHub>("/gameHub");



app.MapRazorPages();

app.Run();