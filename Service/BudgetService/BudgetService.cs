using OficinaMecanica.Dto;
using OficinaMecanica.Infrastructure.Repository;
using OficinaMecanica.Infrastructure.Repository.BudGetItemRepository;
using OficinaMecanica.Models;

namespace OficinaMecanica.Service.BudgetService;

public class BudgetService(IBudgetRepository budgetRepository, IBudgetItemRepository budgetItemRepository) : IBudgetService
{
    public async Task<BudgetDto> AddBudget(BudgetDto budgetDto)
    {

        if (budgetDto.ClintId == 0 || budgetDto.vehicle == 0)
        {
            throw new ArgumentException($"Parametros de Id's informado de forma errada, e necesáriot ter um id valido id do veiculo: {budgetDto.vehicle} id do produto: {budgetDto.ClintId}");
        }
        
        if (budgetDto.BudgetItensList.Count == 0)
        {
            throw new Exception("A lista precisa ter pelo menos um item");
        }
        
        
        var budget = new Budget
        {
            ClintId = budgetDto.ClintId,
            vehicle = budgetDto.vehicle,
            BudgetItensList = budgetDto.BudgetItensList.Select( x=> new BudgetItens
            {
                Descricao = x.Description,
                Quantidade = x.Quantity,
                ValorUnitario = x.UnitValue
            }).ToList()
        };
        
        await budgetRepository.AddBudGet(budget);
        return budgetDto;
    }
}