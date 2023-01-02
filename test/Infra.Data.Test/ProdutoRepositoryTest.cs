using Domain.Models;

namespace Infra.Data.Test;

public class ProdutoRepositoryTest : CrudRepositoryTest<Produto>, IClassFixture<Produto>
{

    public ProdutoRepositoryTest(Produto p) : base(p)
    {
        p.Nome = "diego";
        p.Complemento = "complemento teste";
        p.ProdutoTipo = EProdutoTipo.Revenda;
    }

}
