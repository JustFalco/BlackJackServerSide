﻿using DatabaseLayer.Repositories;
using GameLibrary.Controllers;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Services.Hubs;

namespace Services;

public class Startup
{
	public IConfiguration Configuration { get; }
	public Startup(IConfiguration configuration)
	{
		Configuration = configuration;
	}

	public void ConfigureServices(IServiceCollection services)
	{
		services.AddSignalR();
        services.AddMemoryCache();
        services.AddScoped<GameController>();
        services.AddScoped<IGameRepository, GameRepository>();
    }

	public void Configure(IApplicationBuilder app)
	{
		app.UseRouting();
		app.UseEndpoints(endpoints =>
		{
			endpoints.MapHub<GameHub>("/gameHub");
		});
	}
}