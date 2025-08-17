using Microsoft.EntityFrameworkCore;
using TicketManagement.Application.Contracts.Prestience;

namespace Ticketmanagement.Presistance.Repositories;

public class BaseRepository<T> : IAsyncRepository<T> where T : class
{
    protected TicketmanagemetnDbContext _dbContext;

    public BaseRepository(TicketmanagemetnDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public virtual async Task<IReadOnlyList<T>> GetAllAsync()
    {
        return await _dbContext.Set<T>().ToListAsync();
    }

    public async Task<T> GetByIdAsync(Guid Id)
    {
        return await _dbContext.Set<T>().FindAsync(Id);
    }

    public async Task<T> AddAsync(T entity)
    {
        _dbContext.Set<T>().Add(entity);
        await _dbContext.SaveChangesAsync();
        return entity;
    }

    public async Task DeleteAsync(T entity)
    {
        _dbContext?.Set<T>().Remove(entity);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        _dbContext.Entry(entity).State = EntityState.Modified;
        await _dbContext.SaveChangesAsync();
    }
}
