using MediatR;

namespace TicketManagement.Application.Features.Events;

public class GetEventListedQuery : IRequest<List<EventListViewModel>>
{
}
