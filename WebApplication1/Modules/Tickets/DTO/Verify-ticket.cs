using TodoApi.Shared.Validators;
using System.ComponentModel.DataAnnotations;

namespace XTickets.Modules.Tickets.DTO;

public class VerifyTicketReqestDTO
{
    [Required]
    public string Id { get; set; }

    [Required]
    [Base64]
    public string Signature { get; set; }
}

public class VerifyTicketResponseDTO
{
    public bool IsCorrect { get; set; }
}
