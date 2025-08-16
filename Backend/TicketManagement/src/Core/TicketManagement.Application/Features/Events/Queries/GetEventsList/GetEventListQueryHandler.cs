using AutoMapper;
using MediatR;
using TicketManagement.Application.Contracts.Prestience;
using TicketManagement.Domain.Entities;

namespace TicketManagement.Application.Features.Events.Queries.GetEventsList;

public class GetEventListQueryHandler : IRequestHandler<GetEventListedQuery, List<EventListViewModel>>
{
    private readonly IAsyncRepository<Event> _eventRepository;
    private readonly IMapper _mapper;

    public GetEventListQueryHandler(IAsyncRepository<Event> eventRepo, IMapper mapper)
    {
        _eventRepository = eventRepo;
        _mapper = mapper;
    }

    public async Task<List<EventListViewModel>> Handle(GetEventListedQuery request, CancellationToken cancellationToken)
    {
        var allEvents = (await _eventRepository.GetAllAsync()).OrderBy(e => e.EventDate);
        return _mapper.Map<List<EventListViewModel>>(allEvents);
    }
}
