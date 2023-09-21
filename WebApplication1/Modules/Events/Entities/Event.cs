using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using XTickets.Modules.EventCreators.Entities;

namespace XTickets.Modules.Events.Entities;

public class Event
{
    public int Id { get; set; }

    public EventCreator Creator { get; set; }

    [Required]
    [Column(TypeName = "varchar(64)")]
    public string Title { get; set; }

    [Required]
    [Column(TypeName = "varchar(420)")]
    public string Description { get; set; }

    [Column(TypeName = "varchar(420)")]
    public string AdditionalInfo { get; set; }

    [Required]
    public Place Place { get; set; }

    [Required]
    public DateTime StartsAt { get; set; }

    [Required]
    public DateTime EndsAt { get; set; }


    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
