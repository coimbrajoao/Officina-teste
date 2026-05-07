using Microsoft.AspNetCore.Mvc;
using OficinaMecanica.Dto;
using OficinaMecanica.Models;
using OficinaMecanica.Service.BudgetService;

namespace OficinaMecanica.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BudgetController(IBudgetService budgetService) : Controller
{
    [HttpPost]
    public async Task<ActionResult> AddBudget(BudgetDto budgetRequest)
    {
        var budget = await budgetService.AddBudget(budgetRequest);
        return Ok(budget);
    }
}