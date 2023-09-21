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

    [HttpPost("order")]
    public async Task<ActionResult<BuyTicketResponseDTO>> CreateEvent(BuyTicketRequestDTO dto)
    {
        return StatusCode(501);
    }
}