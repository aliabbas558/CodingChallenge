using System;
using System.Collections.Generic;

namespace Shippment.Persistence.Entities;

public partial class ShipmentRate
{
    public int ShipmentRateId { get; set; }

    public string ShipmentRateClass { get; set; } = null!;

    public string ShipmentRateDescription { get; set; } = null!;

    public virtual ICollection<Shipment> Shipments { get; } = new List<Shipment>();
}
