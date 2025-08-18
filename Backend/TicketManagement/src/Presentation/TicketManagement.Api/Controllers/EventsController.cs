using MediatR;
using Microsoft.AspNetCore.Mvc;
using TicketManagement.Application.Features.Events.Commands.CreateEvent;
using TicketManagement.Application.Features.Events.Commands.UpdateEvent;

namespace TicketManagement.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EventsController : ControllerBase
{
    private readonly IMediator _mediator;
    public EventsController(IMediator mediator)
    {
        _mediator = mediator;   
    }

    [HttpGet( Name ="GetAllEvents")]
    public async Task<IActionResult> GetEvents()
    {
        return Ok("hello");
    }

    [HttpGet("/{eventId}", Name = "GetEvents")]
    public async Task<IActionResult> GetEvents(Guid eventId)
    {
        return Ok("hello");
    }

    [HttpPost]
    public async Task<IActionResult> AddNewEvent(CreateEventCommand newEvent)
    {
        return Ok("hello");
    }

    [HttpPut]
    public async Task<IActionResult> UpdateNewEvent(UpdateEventCommand existingEvent)
    {
        return Ok("hello");
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteEvent()
    {
        return Ok("hello");
    }
}
