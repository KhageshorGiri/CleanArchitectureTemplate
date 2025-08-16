using TicketManagement.Domain.Entities;

namespace TicketManagement.Application.Contracts.Prestience;

public interface IEventRespository : IAsyncRepository<Event>
{
}
