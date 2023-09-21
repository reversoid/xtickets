using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XTickets.Modules.Users.Entities;

public class User
{
    public int Id { get; set; }

    [Required]
    [Column(TypeName = "varchar(32)")]
    public string Name { get; set; }

    [Required]
    [Column(TypeName = "varchar(32)")]
    public string Surname { get; set; }

    [Required]
    [Column(TypeName = "varchar(32)")]
    public string Username { get; set; }

    [Required]
    [Column(TypeName = "varchar(60)")]
    public string PasswordHash { get; set; }

    [Required]
    [Column(TypeName = "varchar(15)")]
    public string PhoneNumber { get; set; }

    [Required]
    [Column(TypeName = "varchar(256)")]
    public string Email { get; set; }


    public DateTime CreatedAt = DateTime.UtcNow;

    public DateTime UpdatedAt = DateTime.UtcNow;
}
