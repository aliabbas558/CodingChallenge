
using Shippment.Models;
using Shippment.Persistence.Entities;

namespace Shippment.Persistence.Repository
{
    public interface IShippmentRepository
    {
        IQueryable<Shipper> Shippers { get; }
        ICollection<ShipperShippmentDetails> GetShipmentDetails(int shipper_id);
    }
}
