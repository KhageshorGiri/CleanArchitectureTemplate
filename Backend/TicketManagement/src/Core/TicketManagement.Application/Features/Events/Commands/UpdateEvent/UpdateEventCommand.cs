using MediatR;

namespace TicketManagement.Application.Features.Events.Commands.UpdateEvent;

public class UpdateEventCommand : IRequest
{
    public Guid EventId { get; set; }
    public string Name { get; set; } = string.Empty;
    public double Price { get; set; }
    public string? Artist { get; set; }
    public DateTime EventDate { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }

    public Guid CategoryId { get; set; }
}
