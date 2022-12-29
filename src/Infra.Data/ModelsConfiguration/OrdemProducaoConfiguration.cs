using Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.ModelsConfiguration;

public class OrdemProducaoConfiguration : IEntityTypeConfiguration<OrdemProducao>
{
    public void Configure(EntityTypeBuilder<OrdemProducao> builder)
    {
        builder.HasKey(opr => opr.Id);
        builder.Property(opr => opr.Numero).HasMaxLength(50);

        builder.HasOne(opr => opr.Produto)
            .WithMany()
            .HasForeignKey(opr => opr.ProdutoId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(opr => opr.LinhaProducao)
            .WithMany()
            .HasForeignKey(opr => opr.LinhaProducaoId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
