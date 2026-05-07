using OficinaMecanica.Infrastructure.Context;
using OficinaMecanica.Models;

namespace OficinaMecanica.Infrastructure.Repository.BudGetItemRepository;

public class BudgetItemItemRepostiory : IBudgetItemRepository
{
    private readonly ApplicationDbContext _dbContext;

    public BudgetItemItemRepostiory(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<BudgetItens> AddBudGetItens(BudgetItens budgetItens)
    {
        _dbContext.BudGetItens.Add(budgetItens);
        await _dbContext.SaveChangesAsync();
        return budgetItens;
    }
}