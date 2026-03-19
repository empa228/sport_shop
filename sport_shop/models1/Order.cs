using System;
using System.Collections.Generic;

namespace sport_shop.models1;

public partial class Order
{
    public int Id { get; set; }

    public DateOnly OrderDate { get; set; }

    public DateOnly? DeliveryDate { get; set; }

    public int? DeliveryPointId { get; set; }

    public int? ClientId { get; set; }

    public int? PickupCode { get; set; }

    public int? StatusId { get; set; }

    public virtual User? Client { get; set; }

    public virtual DeliveryPoint? DeliveryPoint { get; set; }

    public virtual ICollection<OrdersProduct> OrdersProducts { get; set; } = new List<OrdersProduct>();

    public virtual Status? Status { get; set; }
}
