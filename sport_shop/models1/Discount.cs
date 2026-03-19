using System;
using System.Collections.Generic;

namespace sport_shop.models1;

public partial class Discount
{
    public int Id { get; set; }

    public int DiscountPercent { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
