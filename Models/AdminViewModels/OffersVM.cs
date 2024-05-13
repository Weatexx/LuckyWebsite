using System.ComponentModel.DataAnnotations;

namespace holiganbet.Models.AdminViewModels;

public class OffersVM
{
    public int Id { get; set; }

    public string Username { get; set; }

    public string MoneyAmount { get; set; }

    public string OfferDateTime { get; set; }
}