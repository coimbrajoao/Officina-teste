using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OficinaMecanica.Models;

namespace OficinaMecanica.Infrastructure.EntitiesConfiguration;

public class BudGetItemConfiguration : IEntityTypeConfiguration<BudgetItens>
{
    public void Configure(EntityTypeBuilder<BudgetItens> builder)
    {
        builder.HasKey(x => x.idBudGetItens);
        builder.Property(x => x.idBudGetItens);
        
        builder.Property(x => x.Descricao).HasMaxLength(100)
            .IsRequired()
            .HasColumnType("varchar(100)");
        
        builder.Property(x => x.Quantidade)
            .IsRequired();
        
        builder.Property(x => x.ValorUnitario)
            .IsRequired();
        
        builder.HasOne(x => x.Budget)
            .WithMany(x => x.BudgetItensList)
            .HasForeignKey(x => x.BudGetId);
    }
}