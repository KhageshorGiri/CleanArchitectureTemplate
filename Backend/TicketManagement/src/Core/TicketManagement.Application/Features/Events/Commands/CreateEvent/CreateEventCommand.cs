using MediatR;

namespace TicketManagement.Application.Features.Events.Commands.CreateEvent;

public class CreateEventCommand : IRequest<Guid>
{
    public string Name { get; set; } 
    public double Price { get; set; }
    public string? Artist { get; set; }
    public DateTime EventDate { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
    public Guid CategoryId { get; set; }

    public override string ToString()
        => $"Event name: {Name}; Price : {Price}; By: {Artist};" +
            $"On: {EventDate.ToShortDateString()}; Description: {Description}";
}
