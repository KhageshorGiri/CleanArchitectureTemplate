using AutoMapper;
using MediatR;
using TicketManagement.Application.Contracts.Prestience;
using TicketManagement.Domain.Entities;

namespace TicketManagement.Application.Features.Categories.Commands;

public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, CreateCategoryCommandResponse>
{
    private readonly IMapper _mapper;
    private readonly ICategoryRepository _categoryRepository;

    public CreateCategoryCommandHandler(IMapper mapper, ICategoryRepository categoryRespository)
    {
        _mapper = mapper;
        _categoryRepository = categoryRespository;
    }

    public async Task<CreateCategoryCommandResponse> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        var createCategoryCommandResponse = new CreateCategoryCommandResponse();

        // TODO :: validation 

        var category = new Category() { Name = request.Name };
        category = await _categoryRepository.AddAsync(category);

        createCategoryCommandResponse.Category = _mapper.Map<CreateCategoryDto>(category);

        return createCategoryCommandResponse;
    }
}
