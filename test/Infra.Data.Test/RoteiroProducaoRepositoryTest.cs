using Domain.Models;

namespace Infra.Data.Test;

public class RoteiroProducaoRepositoryTest : CrudRepositoryTest<RoteiroProducao>, IClassFixture<RoteiroProducao>
{
    public RoteiroProducaoRepositoryTest(RoteiroProducao roteiro) : base(roteiro)
    {
        roteiro.Empresa = 0;
        roteiro.LinhaProducaoId = 1;
        roteiro.Sequencia = 1;
        roteiro.Descricao = "roteiro teste 1";
    }
    
}
