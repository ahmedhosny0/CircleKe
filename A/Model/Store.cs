using System;
using System.Collections.Generic;

namespace A.Model;

public partial class Store
{
    public int Id { get; set; }

    public string? Location { get; set; }

    public DateTime? Transdate { get; set; }
}
