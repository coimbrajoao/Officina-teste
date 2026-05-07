using System.ComponentModel.DataAnnotations;
using OficinaMecanica.Models;

namespace OficinaMecanica.Dto;

public class BudgetDto
{
    [Required(ErrorMessage = "Id do cliente é obrigatorio")]
    public int ClintId { get; set; }
    
    [Required(ErrorMessage = "Id do veiculo é obrigatorio")]
    public int vehicle { get; set; }
    public List<BudgetItemDto> BudgetItensList { get; set; }
}