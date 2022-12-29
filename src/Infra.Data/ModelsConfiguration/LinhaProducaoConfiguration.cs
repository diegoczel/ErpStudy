using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.ModelsConfiguration;

public class LinhaProducaoConfiguration : IEntityTypeConfiguration<LinhaProducao>
{
    public void Configure(EntityTypeBuilder<LinhaProducao> builder)
    {
        builder.HasKey(lpr => lpr.Id);
        builder.Property(lpr => lpr.Descricao).HasMaxLength(100);
    }
}
