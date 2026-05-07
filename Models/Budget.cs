namespace OficinaMecanica.Models;

public class Budget
{
    public int IdBudget { get; set; }
    public int ClintId { get; set; }
    public int vehicle { get; set; }
    public List<BudgetItens> BudgetItensList { get; set; }
    
}