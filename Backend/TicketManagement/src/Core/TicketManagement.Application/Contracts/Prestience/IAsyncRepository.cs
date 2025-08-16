namespace TicketManagement.Application.Contracts.Prestience;

public interface IAsyncRepository<T> where T : class
{
    Task<T> GetByIdAsync(Guid Id);
    Task<IReadOnlyList<T>> GetAllAsync();
    Task<T> AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}
