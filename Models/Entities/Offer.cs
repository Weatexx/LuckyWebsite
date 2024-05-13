using System;
using System.Collections.Generic;

namespace holiganbet.Models.Entities;

public partial class Offer
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Moneyamount { get; set; } = null!;

    public DateTime Datetime { get; set; }
}
