using MediatR;

namespace TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents;

public class GetCategoryListWithEventQuery : IRequest<List<CategoryEventListViewModel>>
{
    public bool IncludeHistory { get; set; }
}
