using Domain.Models;

namespace Infra.Data.Test;

public class RecursoProducaoRepositoryTest : CrudRepositoryTest<RecursosProducao>, IClassFixture<RecursosProducao>
{
    public RecursoProducaoRepositoryTest(RecursosProducao recurso) : base(recurso)
    {
        recurso.Empresa = 0;
        recurso.RoteiroProducaoId = 1;
        recurso.ProdutoId = 1;
        recurso.QuantidadePadrao = 0m;
    }
    
}
