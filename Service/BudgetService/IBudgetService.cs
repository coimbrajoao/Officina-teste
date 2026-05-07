using OficinaMecanica.Dto;
using OficinaMecanica.Models;

namespace OficinaMecanica.Service.BudgetService;

public interface IBudgetService
{
    Task<BudgetDto> AddBudget(BudgetDto budget);
}