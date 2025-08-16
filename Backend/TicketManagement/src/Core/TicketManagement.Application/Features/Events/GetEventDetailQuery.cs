using MediatR;

namespace TicketManagement.Application.Features.Events;

public class GetEventDetailQuery : IRequest<EventDetailsViewModel>
{
    public Guid Id { get; set; }
}
