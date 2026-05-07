using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OficinaMecanica.Models;

namespace OficinaMecanica.Infrastructure.EntitiesConfiguration;

public class BudgetConfiguration : IEntityTypeConfiguration<Budget>
{
    public void Configure(EntityTypeBuilder<Budget> builder)
    {
        builder.HasKey(x => x.IdBudget);
        builder.Property(x => x.IdBudget);
        builder.Property(x => x.ClintId).IsRequired();
        builder.Property(x => x.vehicle).IsRequired();
        builder.HasMany(x => x.BudgetItensList)
            .WithOne(x => x.Budget)
            .HasForeignKey(x => x.BudGetId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}