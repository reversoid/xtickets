using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XTickets.Modules.Events.Entities;

public class Place
{
    public int Id { get; set; }

    [Required]
    [Column(TypeName = "varchar(32)")]
    public string Name { get; set; }


    // TODO address
}