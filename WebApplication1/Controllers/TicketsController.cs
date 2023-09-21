using Microsoft.AspNetCore.Mvc;
using TodoApi.Services;
using System.ComponentModel.DataAnnotations;
using TodoApi.Shared.Validators;

namespace TodoApi.Controllers;

public class SignTicketDTO
{
    [Required]
    public string Id { get; set; }
}

public class TicketSignResponseDTO
{
    public string Id { get; set; }
    public string Signature { get; set; }
}

public class TicketVerifyResponseDTO
{
    public bool IsCorrect{ get; set; }
}

public class TicketVerifyReqestDTO
{
    [Required]
    public string Id { get; set; }

    [Required]
    [Base64]
    public string Signature { get; set; }
}

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
    public async Task<ActionResult<TicketSignResponseDTO>> SignTicket(SignTicketDTO dto)
    {
        throw new NotImplementedException();
        (string TicketId, string Signature) = _ticketService.SignTicket(dto.Id);
        return Ok(new TicketSignResponseDTO { Id = TicketId, Signature = Signature });
    }

    [HttpPost("verify")]
    public async Task<ActionResult<TicketVerifyResponseDTO>> VerifyTicket(TicketVerifyReqestDTO dto)
    {
        bool IsCorrect = _ticketService.ValidateSignature(dto.Id, dto.Signature);

        return Ok(new TicketVerifyResponseDTO { IsCorrect = IsCorrect });
    }
}