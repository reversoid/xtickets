using System.ComponentModel.DataAnnotations;
using XTickets.Shared.DTO;

namespace XTickets.Modules.Marketplace.DTO;
public class CreateOfferRequestDTO
{
    [Required]
    public string TicketId { get; set; }

    [Required]
    public PriceDTO Price { get; set; }
}

public class CreateOfferResponseDTO
{
    
}


