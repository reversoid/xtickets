using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XTickets.Modules.Admin.Entities;

public class Admin
{
    public int Id { get; set; }

    [Required]
    public string Username { get; set; }

    [Required]
    [Column(TypeName = "varchar(60)")]
    public string PasswordHash { get; set; }


    public DateTime CreatedAt = DateTime.UtcNow;

    public DateTime UpdatedAt = DateTime.UtcNow;
}
