using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XTickets.Shared.Entities;

public class Currency
{
    public int Id { get; set; }

    [Required]
    [Column(TypeName = "char(3)")]
    public string ISOCode { get; set; }

    [Required]
    [Column(TypeName = "char(1)")]
    public string Symbol { get; set; }

    [Required]
    [Column(TypeName = "varchar(32)")]
    public string Name { get; set; }


    public DateTime CreatedAt = DateTime.UtcNow;

    public DateTime UpdatedAt = DateTime.UtcNow;
}

