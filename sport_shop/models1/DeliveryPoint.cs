using System;
using System.Collections.Generic;

namespace sport_shop.models1;

public partial class DeliveryPoint
{
    public int Id { get; set; }

    public string Address { get; set; } = null!;

    public string? Phone { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
