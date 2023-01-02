using Domain.Models;

namespace Infra.Data.Test;

public class OrdemProducaoRepositoryTest : CrudRepositoryTest<OrdemProducao>, IClassFixture<OrdemProducao>
{
    public OrdemProducaoRepositoryTest(OrdemProducao ordem) : base(ordem)
    {
        ordem.Empresa = 0;
        ordem.Numero = "a";
        ordem.ProdutoId = 1;
        ordem.LinhaProducaoId = 1;
        ordem.QuantidadeAbertura = 2;
    }
    
}
