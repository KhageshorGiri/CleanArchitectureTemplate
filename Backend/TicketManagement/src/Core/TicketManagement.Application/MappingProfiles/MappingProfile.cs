using AutoMapper;
using TicketManagement.Application.Features.Categories.Commands;
using TicketManagement.Application.Features.Categories.Queries.GetCategoriesList;
using TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using TicketManagement.Application.Features.Events.Commands.CreateEvent;
using TicketManagement.Application.Features.Events.Commands.UpdateEvent;
using TicketManagement.Application.Features.Events.Queries.GetEventDetails;
using TicketManagement.Application.Features.Events.Queries.GetEventsList;
using TicketManagement.Domain.Entities;

namespace TicketManagement.Application.MappingProfiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Event, EventListViewModel>().ReverseMap();
        CreateMap<Event, EventDetailsViewModel>().ReverseMap();
        CreateMap<Category, CategoryDto>().ReverseMap();
        CreateMap<Category, CreateCategoryDto>().ReverseMap();

        CreateMap<Category, CategoryListViewModel>().ReverseMap();
        CreateMap<Category, CategoryEventListViewModel>().ReverseMap();

        CreateMap<Event, CreateEventCommand>().ReverseMap();
        CreateMap<Event, UpdateEventCommand>().ReverseMap();
        CreateMap<Event, CategoryEventDto>().ReverseMap();
    }
}
