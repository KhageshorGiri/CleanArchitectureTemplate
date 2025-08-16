using MediatR;

namespace TicketManagement.Application.Features.Events.Queries.GetEventsList;

public class GetEventListedQuery : IRequest<List<EventListViewModel>>
{
}
