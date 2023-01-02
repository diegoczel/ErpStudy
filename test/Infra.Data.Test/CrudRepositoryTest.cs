using Domain.Models;
using Infra.Data.Context;

namespace Infra.Data.Test;

public class CrudRepositoryTest<T> where T : Entity
{
    public T _t { get; set; }

    public CrudRepositoryTest(T t)
    {
        _t = t;
    }

    [Fact]
    public void Create_ComDadosValidos_Ok()
    {

        using (var _context = new AppDbContext(AppDbOptions.GetOptions()))
        {
            _context.Set<T>().Add(_t);
            _context.SaveChanges();
        }

        Assert.True(_t.Id > 0);
    }

    [Fact]
    public void GetById_ComIdInvalido_ReturnNull()
    {
        T entity;

        using (var _context = new AppDbContext(AppDbOptions.GetOptions()))
        {
            entity = _context.Set<T>().FirstOrDefault(p => p.Id == -2);
        }

        Assert.Null(entity);
    }

    [Fact]
    public void GetById_ComIdValido_ReturnT()
    {
        T? entity;

        using (var _context = new AppDbContext(AppDbOptions.GetOptions()))
        {
            entity = _context.Set<T>().FirstOrDefault(p => p.Id == 2);
        }

        Assert.NotNull(entity);
    }
}
