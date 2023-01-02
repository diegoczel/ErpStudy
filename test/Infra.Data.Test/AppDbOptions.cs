using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Test;

internal static class AppDbOptions
{
    internal static DbContextOptions<AppDbContext> GetOptions()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>();
        options.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=ErpStudy;Integrated Security=True");
        return options.Options;
    }
}
