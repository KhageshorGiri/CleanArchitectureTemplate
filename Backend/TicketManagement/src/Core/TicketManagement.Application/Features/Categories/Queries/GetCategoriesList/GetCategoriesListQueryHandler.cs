using AutoMapper;
using MediatR;
using TicketManagement.Application.Contracts.Prestience;
using TicketManagement.Domain.Entities;

namespace TicketManagement.Application.Features.Categories.Queries.GetCategoriesList;

public class GetCategoriesListQueryHandler : IRequestHandler<GetCategoriesListQuery, List<CategoryListViewModel>>
{
    private readonly IAsyncRepository<Category> _categoryRepository;
    private readonly IMapper _mapper;

    public GetCategoriesListQueryHandler(IAsyncRepository<Category> categoryRepo, IMapper mapper)
    {
        _categoryRepository = categoryRepo;
        _mapper = mapper;
    }
    public async Task<List<CategoryListViewModel>> Handle(GetCategoriesListQuery request, CancellationToken cancellationToken)
    {
        var allCategories = (await _categoryRepository.GetAllAsync()).OrderBy(x => x.Name);
        return _mapper.Map<List<CategoryListViewModel>>(allCategories);
    }
}
