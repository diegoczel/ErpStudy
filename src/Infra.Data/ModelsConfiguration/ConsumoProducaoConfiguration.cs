using Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.ModelsConfiguration;

public class ConsumoProducaoConfiguration : IEntityTypeConfiguration<ConsumoProducao>
{
    public void Configure(EntityTypeBuilder<ConsumoProducao> builder)
    {
        builder.HasKey(cpr => cpr.Id);

        builder.HasOne(cpr => cpr.OrdemProducao)
            .WithMany()
            .HasForeignKey(cpr => cpr.OrdemProducaoId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(cpr => cpr.ApontamentoProducao)
            .WithMany()
            .HasForeignKey(cpr => cpr.ApontamentoProducaoId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(cpr => cpr.Produto)
            .WithMany()
            .HasForeignKey(cpr => cpr.ProdutoId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
