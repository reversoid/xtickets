using TodoApi.Shared.Validators;
using System.ComponentModel.DataAnnotations;

namespace XTickets.Modules.Tickets.DTO;

public class VerifyTicketRequestDTO
{
    [Required]
    public string Id { get; set; }

    [Required]
    [Base64]
    public string Signature { get; set; }
}

public class VerifyTicketResponseDTO
{
    [Required]
    public bool IsCorrect { get; set; }
}
