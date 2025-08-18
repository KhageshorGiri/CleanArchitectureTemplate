using MediatR;
using Microsoft.AspNetCore.Mvc;
using TicketManagement.Application.Features.Categories.Commands;

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
        return Ok("hello");
    }

    [HttpGet("events", Name = "GetAllCategoriesWithEvents")]
    public async Task<IActionResult> GetAllCategoriesWithEvents()
    {
        return Ok("hello");
    }

    [HttpPost]
    public async Task<IActionResult> AddNewCategory(CreateCategoryCommand newCategory)
    {
        return Ok("ok");
    }

}
