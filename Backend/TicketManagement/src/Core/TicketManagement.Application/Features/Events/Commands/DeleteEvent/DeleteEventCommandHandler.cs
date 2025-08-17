using AutoMapper;
using MediatR;
using TicketManagement.Application.Contracts.Prestience;

namespace TicketManagement.Application.Features.Events.Commands.DeleteEvent;

public class DeleteEventCommandHandler : IRequestHandler<DeleteEventCommand>
{
    private readonly IMapper _mapper;
    private readonly IEventRespository _eventRespository;

    public DeleteEventCommandHandler(IMapper mapper, IEventRespository eventRespository)
    {
        _mapper = mapper;
        _eventRespository = eventRespository;
    }

    public async Task Handle(DeleteEventCommand request, CancellationToken cancellationToken)
    {
        var eventToDelete = await _eventRespository.GetByIdAsync(request.EventId);
        await _eventRespository.DeleteAsync(eventToDelete);
    }
}
