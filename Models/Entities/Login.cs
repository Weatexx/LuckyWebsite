using System;
using System.Collections.Generic;

namespace holiganbet.Models.Entities;

public partial class Login
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;
}
