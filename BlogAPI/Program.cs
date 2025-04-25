using Microsoft.EntityFrameworkCore;
using BlogApi.Infrastructure.Data;
using BlogApi.Application.Interfaces;
using BlogApi.Infrastructure.Repositories;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IPostRepository, PostRepository>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");



app.Run();