using MediatR;
using Microsoft.AspNetCore.Mvc;
using TicketManagement.Application.Features.Events.Commands.CreateEvent;
using TicketManagement.Application.Features.Events.Commands.DeleteEvent;
using TicketManagement.Application.Features.Events.Commands.UpdateEvent;
using TicketManagement.Application.Features.Events.Queries.GetEventDetails;
using TicketManagement.Application.Features.Events.Queries.GetEventsList;

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

    [HttpGet]
    public async Task<IActionResult> GetEvents()
    {
        var response = await _mediator.Send(new GetEventListedQuery());
        return Ok(response);
    }

    [HttpGet("/{eventId}")]
    public async Task<IActionResult> GetEvents(Guid eventId)
    {
        var response = await _mediator.Send(new GetEventDetailQuery { Id = eventId});
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> AddNewEvent(CreateEventCommand newEvent)
    {
        var response = await _mediator.Send(newEvent);
        return CreatedAtAction("GetEvents", response);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateNewEvent(UpdateEventCommand existingEvent)
    {
        await _mediator.Send(existingEvent);
        return NoContent();
    }

    [HttpDelete("{eventId}")]
    public async Task<IActionResult> DeleteEvent(Guid eventId)
    {
        await _mediator.Send(new DeleteEventCommand { EventId = eventId });
        return NoContent();
    }
}
