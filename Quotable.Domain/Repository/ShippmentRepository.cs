using Microsoft.EntityFrameworkCore;
using Shippment.Models;
using Shippment.Persistence.Context;
using Shippment.Persistence.Entities;

namespace Shippment.Persistence.Repository
{
    public class ShippmentRepository : IShippmentRepository
    {
        private readonly IShippmentDatabaseContext _databaseContext;

        public ShippmentRepository(IShippmentDatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public virtual IQueryable<Shipper> Shippers
        {
            get
            {
                return _databaseContext.Shippers;
            }
        }

        public ICollection<ShipperShippmentDetails> GetShipmentDetails(int shipper_id)
        {
            return  _databaseContext.GetShipperShippmentDetails(shipper_id);
        }
    }
}
