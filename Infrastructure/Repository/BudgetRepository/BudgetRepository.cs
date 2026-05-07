using OficinaMecanica.Infrastructure.Context;
using OficinaMecanica.Models;

namespace OficinaMecanica.Infrastructure.Repository;

public class BudgetRepository : IBudgetRepository
{
    private readonly ApplicationDbContext _dbContext;

    public BudgetRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<Budget> AddBudGet(Budget budget)
    {
        _dbContext.Budgets.Add(budget);
        await _dbContext.SaveChangesAsync();
        return budget;
    }
}