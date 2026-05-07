using OficinaMecanica.Models;

namespace OficinaMecanica.Infrastructure.Repository;

public interface IBudgetRepository
{
    Task<Budget> AddBudGet(Budget budget);
}