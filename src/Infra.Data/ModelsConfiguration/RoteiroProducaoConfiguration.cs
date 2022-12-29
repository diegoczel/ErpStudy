using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.ModelsConfiguration;

public class RoteiroProducaoConfiguration : IEntityTypeConfiguration<RoteiroProducao>
{
    public void Configure(EntityTypeBuilder<RoteiroProducao> builder)
    {
        builder.HasKey(rpr => rpr.Id);

        builder.HasOne(rpr => rpr.LinhaProducao)
            .WithMany()
            .HasForeignKey(rpr => rpr.LinhaProducaoId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.Property(rpr => rpr.Descricao).HasMaxLength(100);
    }
}
