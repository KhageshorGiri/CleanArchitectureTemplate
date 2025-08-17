using AutoMapper;
using MediatR;
using TicketManagement.Application.Contracts.Prestience;
using TicketManagement.Domain.Entities;

namespace TicketManagement.Application.Features.Events.Commands.CreateEvent;

public class CreateEventCommandHandler : IRequestHandler<CreateEventCommand, Guid>
{
    private readonly IMapper _mapper;
    private readonly IEventRespository _eventRespository;

    public CreateEventCommandHandler(IMapper mapper, IEventRespository eventRespository)
    {
        _mapper = mapper;   
        _eventRespository = eventRespository;
    }

    public async Task<Guid> Handle(CreateEventCommand request, CancellationToken cancellationToken)
    {
        var @event = _mapper.Map<Event>(request);
        @event = await _eventRespository.AddAsync(@event);
        return @event.EventId;
    }
}
