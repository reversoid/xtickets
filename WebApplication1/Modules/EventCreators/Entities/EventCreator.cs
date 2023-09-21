using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XTickets.Modules.EventCreators.Entities;

public class EventCreator
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

    [Required]
    [Column(TypeName = "varchar(192)")]
    public string ImageUrl { get; set; }

    public bool Verified = false;

    public bool PhoneVerified = false;

    public bool EmailVerified = false;


    public DateTime CreatedAt = DateTime.UtcNow;

    public DateTime UpdatedAt = DateTime.UtcNow;
}
