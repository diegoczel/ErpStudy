using Domain.Models;

namespace Infra.Data.Test;

public class ConsumoProducaoRepositoryTest : CrudRepositoryTest<ConsumoProducao>, IClassFixture<ConsumoProducao>
{
    public ConsumoProducaoRepositoryTest(ConsumoProducao consumo) : base(consumo)
    {
        consumo.Empresa = 0;
        consumo.OrdemProducaoId = 2;
        consumo.ApontamentoProducaoId = 2;
        consumo.ProdutoId = 3;
        consumo.Quantidade = 3m;
    }
    
}
