using Shippment.Models;
using Shippment.Persistence.Repository;

namespace Shippment.Business
{
    public class ShippmentService: IShippmentService
    {
        private readonly IShippmentRepository _shippmentRepository;

        public ShippmentService(IShippmentRepository shippmentRepository)
        {
            _shippmentRepository = shippmentRepository;
        }

        public async Task<ICollection<ShipperDto>> GetShippers()
        {
            var test = _shippmentRepository.GetShipmentDetails(1);
            return _shippmentRepository.Shippers
                .Select(shipper => new ShipperDto
                {
                    Name = shipper.ShipperName,
                    Id = shipper.ShipperId,
                })
                .OrderBy(x=>x.Name)
                .ToList();
        }

        public ICollection<ShipperShippmentDetails> GetShipperShippmentDetails(int shipperId)
        {
            return _shippmentRepository
                .GetShipmentDetails(shipperId)
                .OrderBy(d=>d.ShipperName)
                .ToList();
        }
    }
}
