namespace Shippment.Persistence.Entities;

public partial class Carrier
{
    public int CarrierId { get; set; }

    public string CarrierName { get; set; } = null!;

    public string CarrierMode { get; set; } = null!;

    public virtual ICollection<Shipment> Shipments { get; } = new List<Shipment>();
}
