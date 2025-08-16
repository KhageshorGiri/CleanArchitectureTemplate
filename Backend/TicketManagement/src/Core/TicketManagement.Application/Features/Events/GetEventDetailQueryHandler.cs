using AutoMapper;
using MediatR;
using TicketManagement.Application.Contracts.Prestience;
using TicketManagement.Domain.Entities;

namespace TicketManagement.Application.Features.Events;

public class GetEventDetailQueryHandler : IRequestHandler<GetEventDetailQuery, EventDetailsViewModel>
{
    private readonly IAsyncRepository<Event> _eventRepository;
    private readonly IAsyncRepository<Category> _categoryRepository;
    private readonly IMapper _mapper;

    public GetEventDetailQueryHandler(
        IAsyncRepository<Event> eventRepo,
        IAsyncRepository<Category> categoryRepo,
        IMapper mapper)
    {
        _eventRepository = eventRepo;
        _categoryRepository = categoryRepo;
        _mapper = mapper;
    }

    public async Task<EventDetailsViewModel> Handle(GetEventDetailQuery request, CancellationToken cancellationToken)
    {
        var @event = await _eventRepository.GetByIdAsync(request.Id);
        var eventDetailDto = _mapper.Map<EventDetailsViewModel>(@event);

        var category = await _categoryRepository.GetByIdAsync(@event.CategoryId);
        eventDetailDto.Category = _mapper.Map<CategoryDto>(category);
        
        return eventDetailDto;
    }
}
