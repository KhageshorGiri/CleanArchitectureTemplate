using TicketManagement.Domain.Entities;

namespace TicketManagement.Application.Contracts.Prestience;

public interface ICategoryRepository : IAsyncRepository<Category>
{
    Task<List<Category>> GetCategoriesWithEvents(bool includeHistory);
}
