using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.ModelsConfiguration;

public class ApontamentoProducaoConfiguration : IEntityTypeConfiguration<ApontamentoProducao>
{
    public void Configure(EntityTypeBuilder<ApontamentoProducao> builder)
    {
        builder.HasKey(apr => apr.Id);

        builder.HasOne(apr => apr.OrdemProducao)
            .WithMany()
            .HasForeignKey(apr => apr.OrdemProducaoId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(apr => apr.RoteiroProducaoOrigem)
            .WithMany()
            .HasForeignKey(apr => apr.RoteiroProducaoOrigemId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(apr => apr.RoteiroProducaoDestino)
            .WithMany()
            .HasForeignKey(apr => apr.RoteiroProducaoOrigemId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
