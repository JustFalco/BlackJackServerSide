using DatabaseLayer.DAL.Contexts;
using DatabaseLayer.Repositories;
using GameLibrary.Controllers;
using Services.Hubs;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

/*builder.Services.AddCors(c => c.AddPolicy("AllowOrigin",
    policyBuilder => policyBuilder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod().Build()));*/

builder.Services.AddSignalR();
builder.Services.AddScoped<GameController>();
builder.Services.AddScoped<GameHub>();
builder.Services.AddScoped<IGameRepository, GameRepository>();
/*builder.Services.AddDbContext<GameContext>(
    options => options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection")))
    );*/

builder.Services.AddDbContext<GameContext>(
    options => options.UseInMemoryDatabase(databaseName: "InMemoryDatabase")
);

/*builder.Services.AddDbContext<GameContext>();*/
builder.Services.AddMemoryCache();



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

/*app.UseCors(options => options.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod().Build());*/

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapHub<GameHub>("/gameHub");
});

app.UseAuthorization();

app.MapRazorPages();

app.Run();