using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shippment.Business;

namespace Quotable.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipperController : ControllerBase
    {
        private readonly IShippmentService _shippmentService;

        public ShipperController(IShippmentService shippmentService)
        {
            _shippmentService = shippmentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetShippers()
        {
            var shippers = await _shippmentService.GetShippers();
            return Ok(shippers);
        }
        [HttpGet("details")]
        public IActionResult GetShipperShippmentDetails([FromQuery] int shipperId)
        {
            var shipperShippmentDetails = _shippmentService.GetShipperShippmentDetails(shipperId);
            return Ok(shipperShippmentDetails);
        }
    }
}
