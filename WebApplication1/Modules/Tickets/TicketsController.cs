using Microsoft.AspNetCore.Mvc;


namespace XTickets.Modules.Tickets.DTO;



[Route("api/[controller]")]
[ApiController]
public class TicketsController : ControllerBase
{
    private readonly ITicketService _ticketService;

    public TicketsController(ITicketService ticketService)
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
    public async Task<ActionResult<VerifyTicketResponseDTO>> VerifyTicket(VerifyTicketReqestDTO dto)
    {
        bool isCorrect = _ticketService.ValidateTicket(dto.Id, dto.Signature);

        return Ok(new VerifyTicketResponseDTO { IsCorrect = isCorrect });
    }
}