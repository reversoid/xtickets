using Microsoft.AspNetCore.Mvc;
using XTickets.Modules.Shop.DTO;

namespace XTickets.Modules.Shop;



[Route("api/[controller]")]
[ApiController]
public class ShopController : ControllerBase
{
    private readonly IShopService _shopService;

    public ShopController(IShopService shopService)
    {
        _shopService = shopService;
    }

    [HttpPost("event")]
    public async Task<ActionResult<CreateEventResponseDTO>> CreateEvent(CreateEventRequestDTO dto)
    {
        return StatusCode(501);
    }

    [HttpDelete("event/{id}")]
    public async Task<ActionResult<CancelEventResponseDTO>> CancelEvent(int id, CancelEventRequestDTO dto)
    {
        return StatusCode(501);
    }
}