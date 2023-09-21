using Microsoft.AspNetCore.Mvc;
using XTickets.Modules.Tickets.DTO;

namespace XTickets.Modules.Tickets;



[Route("api/[controller]")]
[ApiController]
public class TicketController : ControllerBase
{
    private readonly ITicketService _ticketService;

    public TicketController(ITicketService ticketService)
    {
        _ticketService = ticketService;
    }

    [HttpPost("sign")]
    public async Task<ActionResult<SignTicketResponseDTO>> SignTicket(SignTicketRequestDTO dto)
    {
        (string ticketId, string signature) = _ticketService.SignTicket(dto.Id);
        return Ok(new SignTicketResponseDTO { Id = ticketId, Signature = signature });
    }

    [HttpPost("verify")]
    public async Task<ActionResult<VerifyTicketResponseDTO>> VerifyTicket(VerifyTicketRequestDTO dto)
    {
        bool isCorrect = _ticketService.ValidateTicket(dto.Id, dto.Signature);

        return Ok(new VerifyTicketResponseDTO { IsCorrect = isCorrect });
    }
}