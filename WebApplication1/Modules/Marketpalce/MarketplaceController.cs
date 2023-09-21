using Microsoft.AspNetCore.Mvc;
using XTickets.Modules.Marketplace.DTO;

namespace XTickets.Modules.Marketplace;


[Route("api/[controller]")]
[ApiController]
public class MarketplaceController : ControllerBase
{
    private readonly IMarketplaceService _marketplaceService;

    public MarketplaceController(IMarketplaceService marketplaceService)
    {
        _marketplaceService = marketplaceService;
    }

    [HttpPost("offers")]
    public async Task<ActionResult<CreateOfferResponseDTO>> CreateOffer(CreateOfferRequestDTO dto)
    {
        return StatusCode(501);
    }

    [HttpDelete("offers/{id}")]
    public async Task<ActionResult<CancelOfferResponseDTO>> CancelOffer(string id)
    {
        return StatusCode(501);
    }
}