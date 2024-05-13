using System;
using System.Collections.Generic;

namespace holiganbet.Models.Entities;

public partial class Contact
{
    public int Id { get; set; }

    public string Namesurname { get; set; } = null!;

    public string Phone { get; set; } = null!;
}
