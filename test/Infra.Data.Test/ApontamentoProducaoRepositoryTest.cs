using Domain.Models;

namespace Infra.Data.Test;

public class ApontamentoProducaoRepositoryTest : CrudRepositoryTest<ApontamentoProducao>, IClassFixture<ApontamentoProducao>
{
    public ApontamentoProducaoRepositoryTest(ApontamentoProducao apontamento) : base(apontamento)
    {
        apontamento.Empresa = 0;
        apontamento.OrdemProducaoId = 2;
        apontamento.RoteiroProducaoOrigemId = 1;
        apontamento.RoteiroProducaoDestinoId = 2;
        apontamento.Quantidade = 1.0m;
    }
    
}
