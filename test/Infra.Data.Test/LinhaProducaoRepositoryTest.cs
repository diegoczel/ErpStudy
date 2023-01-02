using Domain.Models;

namespace Infra.Data.Test;

public class LinhaProducaoRepositoryTest : CrudRepositoryTest<LinhaProducao>, IClassFixture<LinhaProducao>
{
    public LinhaProducaoRepositoryTest(LinhaProducao linha) : base(linha)
    {
        linha.Empresa = 0;
        linha.Descricao = "desc teste";
    }
    
}
