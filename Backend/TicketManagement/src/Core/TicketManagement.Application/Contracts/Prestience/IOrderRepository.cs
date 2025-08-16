using TicketManagement.Domain.Entities;

namespace TicketManagement.Application.Contracts.Prestience;

public interface IOrderRepository : IAsyncRepository<Order>
{
}
