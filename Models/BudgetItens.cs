namespace OficinaMecanica.Models;

public class BudgetItens
{
    public int idBudGetItens { get; set; }
    public string Descricao { get; set; }
    public int Quantidade { get; set; }
    public decimal ValorUnitario { get; set; }
    public int BudGetId { get; set; }
    public Budget Budget { get; set; }
}