using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.ModelsConfiguration;

public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
{
    public void Configure(EntityTypeBuilder<Produto> builder)
    {
        builder.HasKey(pro => pro.Id);
        builder.Property(pro => pro.Nome).HasMaxLength(100);
        builder.Property(pro => pro.Complemento).HasMaxLength(100);
    }
}
