using Domain.Models;

namespace Domain.Interfaces;

public interface ICrudRepository<T> where T : Entity
{
    Task<T> CreateAsync(T entity);

    Task<T>? GetByIdAsync(int id);
}
