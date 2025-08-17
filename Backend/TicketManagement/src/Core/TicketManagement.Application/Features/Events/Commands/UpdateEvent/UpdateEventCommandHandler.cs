using AutoMapper;
using MediatR;
using TicketManagement.Application.Contracts.Prestience;
using TicketManagement.Domain.Entities;

namespace TicketManagement.Application.Features.Events.Commands.UpdateEvent;

public class UpdateEventCommandHandler : IRequestHandler<UpdateEventCommand>
{
    private readonly IMapper _mapper;
    private readonly IEventRespository _eventRespository;

    public UpdateEventCommandHandler(IMapper mapper, IEventRespository eventRespository)
    {
        _mapper = mapper;
        _eventRespository = eventRespository;
    }

    public async Task Handle(UpdateEventCommand request, CancellationToken cancellationToken)
    {
        var eventToUpdate = await _eventRespository.GetByIdAsync(request.EventId);

        _mapper.Map(request, eventToUpdate, typeof(UpdateEventCommand), typeof(Event))

        await _eventRespository.UpdateAsync(eventToUpdate);
    }
}
