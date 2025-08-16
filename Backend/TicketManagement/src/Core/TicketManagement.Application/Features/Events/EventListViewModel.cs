namespace TicketManagement.Application.Features.Events;

public class EventListViewModel
{
    public Guid EventId { get; set; }
    public string Name { get; set; }
    public DateTime EventDate { get; set; }
    public string? ImageUrl { get; set; }
}
