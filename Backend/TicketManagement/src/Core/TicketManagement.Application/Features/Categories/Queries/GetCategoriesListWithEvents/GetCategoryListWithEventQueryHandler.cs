using AutoMapper;
using MediatR;
using TicketManagement.Application.Contracts.Prestience;

namespace TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents;

public class GetCategoryListWithEventQueryHandler :
    IRequestHandler<GetCategoryListWithEventQuery, List<CategoryEventListViewModel>>
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public GetCategoryListWithEventQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public async Task<List<CategoryEventListViewModel>> Handle(GetCategoryListWithEventQuery request, CancellationToken cancellationToken)
    {
        var list = await _categoryRepository.GetCategoriesWithEvents(request.IncludeHistory);
        return _mapper.Map<List<CategoryEventListViewModel>>(list);
    }
}
