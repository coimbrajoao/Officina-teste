namespace OficinaMecanica.Models;

public class Budget
{
    public int IdBudget { get; set; }
    public int ClintId { get; set; }
    public int vehicle { get; set; }

    public decimal TotalValue { get; private set; }
    public List<BudgetItens> BudgetItensList { get; set; }

    public void CalcularTotal()
    {
        TotalValue = BudgetItensList.Sum(x => x.Quantidade  * x.ValorUnitario);
    }
    
}