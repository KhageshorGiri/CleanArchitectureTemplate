using Microsoft.EntityFrameworkCore;
using TicketManagement.Domain.Entities;

namespace Ticketmanagement.Presistance;

public class TicketmanagemetnDbContext : DbContext
{
    public TicketmanagemetnDbContext(DbContextOptions<TicketmanagemetnDbContext> options): base(options)
    {
    }

    public DbSet<Event> Events { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Order> Orders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(TicketmanagemetnDbContext).Assembly);
    }
}
