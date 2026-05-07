using Microsoft.EntityFrameworkCore;
using OficinaMecanica.Infrastructure.Context;
using OficinaMecanica.Infrastructure.Repository;
using OficinaMecanica.Infrastructure.Repository.BudGetItemRepository;
using OficinaMecanica.Service.BudgetService;

namespace OficinaMecanica.Infra.Ioc;

public static class DependecyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseMySQL(configuration.GetConnectionString("DefaultConnection"),
                optionsBuilder => optionsBuilder.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName));
        });
        services.AddScoped<IBudgetRepository, BudgetRepository>();
        services.AddScoped<IBudgetService, BudgetService>();
        services.AddScoped<IBudgetItemRepository, BudgetItemItemRepostiory>();
        return services;
    }
}