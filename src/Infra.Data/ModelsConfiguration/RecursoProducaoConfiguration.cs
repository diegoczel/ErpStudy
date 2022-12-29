using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.ModelsConfiguration;

public class RecursoProducaoConfiguration : IEntityTypeConfiguration<RecursosProducao>
{
    public void Configure(EntityTypeBuilder<RecursosProducao> builder)
    {
        builder.HasKey(rpr => rpr.Id);
        
        builder.HasOne(rpr => rpr.RoteiroProducao)
            .WithMany()
            .HasForeignKey(rpr => rpr.RoteiroProducaoId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
