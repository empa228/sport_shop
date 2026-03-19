using System;
using System.Collections.Generic;

namespace sport_shop.models1;

public partial class Product
{
    public int Id { get; set; }

    public string Sku { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public int? CategoryId { get; set; }

    public int? ManufacturerId { get; set; }

    public int? SupplierId { get; set; }

    public decimal Price { get; set; }

    public string? Unit { get; set; }

    public int? DiscountId { get; set; }

    public int? StockQuantity { get; set; }

    public string? Description { get; set; }

    public virtual Category? Category { get; set; }

    public virtual Discount? Discount { get; set; }

    public virtual Manufacturer? Manufacturer { get; set; }

    public virtual ICollection<OrdersProduct> OrdersProducts { get; set; } = new List<OrdersProduct>();

    public virtual Supplier? Supplier { get; set; }
}
