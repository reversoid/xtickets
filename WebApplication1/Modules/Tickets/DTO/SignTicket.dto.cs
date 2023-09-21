using System.ComponentModel.DataAnnotations;

namespace XTickets.Modules.Tickets.DTO;
public class SignTicketRequestDTO
{
    [Required]
    public string Id { get; set; }
}

public class SignTicketResponseDTO
{
    public string Id { get; set; }
    public string Signature { get; set; }
}


