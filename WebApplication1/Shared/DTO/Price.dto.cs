using System.ComponentModel.DataAnnotations;

namespace XTickets.Shared.DTO;

public class PriceDTO
{
    [Required]
    public decimal Value { get; set; }

    [Required]
    public int CurrencyId { get; set; }
}

