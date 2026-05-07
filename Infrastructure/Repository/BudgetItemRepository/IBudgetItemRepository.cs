using OficinaMecanica.Models;

namespace OficinaMecanica.Infrastructure.Repository.BudGetItemRepository;

public interface IBudgetItemRepository
{
    Task<BudgetItens> AddBudGetItens(BudgetItens budgetItens);
}