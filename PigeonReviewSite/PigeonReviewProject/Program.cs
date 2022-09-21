
global using PigeonReviewProject.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PigeonReviewProject.DBContext;
using PigeonReviewProject.Interfaces;
using PigeonReviewProject.Repositories;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

        builder.Services.AddScoped<IPigeonRepository, PigeonRepository>();
        builder.Services.AddScoped<ICattegoryRepository, CategoryRepository>();
        builder.Services.AddScoped<IDistrictRepository, DistrictRepository>();

        builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddDbContext<PigeonDBContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("PigeonAPIDb")));


        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}