using TicketManagement.Application.Contracts.Prestience;
using TicketManagement.Domain.Entities;

namespace Ticketmanagement.Presistance.Repositories;

public class EventRepository : BaseRepository<Event>, IEventRespository
{
    public EventRepository(TicketmanagemetnDbContext dbContext) : base(dbContext)
    {
    }

}
