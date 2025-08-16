using AutoMapper;
using TicketManagement.Application.Features.Categories.Queries.GetCategoriesList;
using TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
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

        CreateMap<Category, CategoryListViewModel>().ReverseMap();
        CreateMap<Category, CategoryEventListViewModel>().ReverseMap();
    }
}
