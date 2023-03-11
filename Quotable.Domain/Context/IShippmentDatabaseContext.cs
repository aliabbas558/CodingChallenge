using Microsoft.EntityFrameworkCore;
using Shippment.Models;
using Shippment.Persistence.Entities;

namespace Shippment.Persistence.Context
{
    public interface IShippmentDatabaseContext 
    {
        DbSet<Carrier> Carriers { get; set; }

        DbSet<Shipment> Shipments { get; set; }

        DbSet<ShipmentRate> ShipmentRates { get; set; }

        DbSet<Shipper> Shippers { get; set; }
        ICollection<ShipperShippmentDetails> GetShipperShippmentDetails(int shipper_id);
    }
}
