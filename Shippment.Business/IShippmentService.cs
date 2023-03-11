using Shippment.Models;

namespace Shippment.Business
{
    public interface IShippmentService
    {
        Task<ICollection<ShipperDto>> GetShippers();
        ICollection<ShipperShippmentDetails> GetShipperShippmentDetails(int shipperId);
    }
}