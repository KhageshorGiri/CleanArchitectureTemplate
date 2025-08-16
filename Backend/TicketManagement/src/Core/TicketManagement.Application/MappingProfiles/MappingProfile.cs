using AutoMapper;
using TicketManagement.Application.Features.Events;
using TicketManagement.Domain.Entities;

namespace TicketManagement.Application.MappingProfiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Event, EventListViewModel>().ReverseMap();
        CreateMap<Event, EventDetailsViewModel>().ReverseMap();
        CreateMap<Category, CategoryDto>().ReverseMap();
    }
}
