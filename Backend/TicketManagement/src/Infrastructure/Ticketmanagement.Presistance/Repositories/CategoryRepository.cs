using Microsoft.EntityFrameworkCore;
using TicketManagement.Application.Contracts.Prestience;
using TicketManagement.Domain.Entities;

namespace Ticketmanagement.Presistance.Repositories;

public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
{
    public CategoryRepository(TicketmanagemetnDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<List<Category>> GetCategoriesWithEvents(bool includeHistory)
    {
        var allCategories = await _dbContext.Categories.Include(x =>
            x.Events).ToListAsync();
        if (!includeHistory)
        {
            allCategories.ForEach(x => x.Events.ToList().RemoveAll(c => c.EventDate < DateTime.Today));
        }
        return allCategories;
    }
}
