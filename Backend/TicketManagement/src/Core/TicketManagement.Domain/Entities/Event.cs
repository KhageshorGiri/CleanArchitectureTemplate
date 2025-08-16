using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TicketManagement.Domain.Common;

namespace TicketManagement.Domain.Entities;

public class Event : AuditableEntity
{
    [Key]
    public Guid EventId { get; set; }
    public string Name { get; set; } = string.Empty;
    public double Price { get; set; }
    public string? Artist { get; set; }
    public DateTime EventDate { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }

    [ForeignKey(nameof(Category))]
    public Guid CategoryId { get; set; }
    public Category Category { get; set; } = default!;
}
