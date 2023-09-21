using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using XTickets.Modules.Tickets.Entities;
using XTickets.Shared.Entities;

namespace XTickets.Modules.Users.Entities;

public class Offer
{
    public long Id { get; set; }

    [Required]
    public int Price { get; set; }

    [Required]
    public Currency Currency { get; set; }

    [Required]
    public Ticket Ticket { get; set; }

    public DateTime CreatedAt = DateTime.UtcNow;

    public DateTime UpdatedAt = DateTime.UtcNow;
}
