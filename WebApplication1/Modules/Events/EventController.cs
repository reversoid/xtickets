using Microsoft.AspNetCore.Mvc;
using XTickets.Modules.Events.DTO;

namespace XTickets.Modules.Events;



[Route("api/[controller]")]
[ApiController]
public class EventController : ControllerBase
{
    private readonly IEventService _eventService;

    public EventController(IEventService eventService)
    {
        _eventService = eventService;
    }

    [HttpPost]
    public async Task<ActionResult<CreateEventResponseDTO>> CreateEvent(CreateEventRequestDTO dto)
    {
        return StatusCode(501);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<CancelEventResponseDTO>> CancelEvent(int id, CancelEventRequestDTO dto)
    {
        return StatusCode(501);
    }
}