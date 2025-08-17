using TicketManagement.Application.Contracts.Prestience;
using TicketManagement.Domain.Entities;

namespace Ticketmanagement.Presistance.Repositories;

public class OrderRepository : BaseRepository<Order>, IOrderRepository
{
    public OrderRepository(TicketmanagemetnDbContext dbContext) : base(dbContext)
    {
    }
}
