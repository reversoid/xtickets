using System.ComponentModel.DataAnnotations;
using XTickets.Modules.Events.Entities;
using XTickets.Modules.Users.Entities;

namespace XTickets.Modules.Tickets.Entities;

public enum TicketStatus
{
    Active = 1,
    OnSale = 2,
    Inactive = 3
}

public class Ticket
{
    // TODO use uuid
    public string Id { get; set; }

    [Required]
    public User User { get; set; }

    [Required]
    public Event Event { get; set; }

    // TODO use string enum. Look for docs.
    public TicketStatus status;


    public DateTime CreatedAt = DateTime.UtcNow;

    public DateTime UpdatedAt = DateTime.UtcNow;
}
