using OficinaMecanica.Models;

namespace OficinaMecanica.Infrastructure.Repository.BudGetItemRepository;

public interface IBudgetRepository
{
    Task<BudgetItens> AddBudGetItens(BudgetItens budgetItens);
}