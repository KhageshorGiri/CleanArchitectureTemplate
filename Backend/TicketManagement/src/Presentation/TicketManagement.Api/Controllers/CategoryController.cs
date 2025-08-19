using MediatR;
using Microsoft.AspNetCore.Mvc;
using TicketManagement.Application.Features.Categories.Commands;
using TicketManagement.Application.Features.Categories.Queries.GetCategoriesList;
using TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents;

namespace TicketManagement.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly IMediator _mediator;
    public CategoryController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet (Name = "GetAllCategories")]
    public async Task<IActionResult> GetAllCategories()
    {
        var allCategories = await _mediator.Send(new GetCategoriesListQuery());
        return Ok(allCategories);
    }

    [HttpGet("events", Name = "GetAllCategoriesWithEvents")]
    public async Task<IActionResult> GetAllCategoriesWithEvents([FromQuery] bool includeHistory)
    {
        var response = await _mediator.Send(new GetCategoryListWithEventQuery { IncludeHistory = includeHistory });
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> AddNewCategory(CreateCategoryCommand newCategory)
    {
        var response = await _mediator.Send(newCategory);
        return CreatedAtAction("GetAllCategories", response);
    }

}
