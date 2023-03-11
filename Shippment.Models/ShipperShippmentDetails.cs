namespace Shippment.Models
{
    public class ShipperShippmentDetails
    {
        public int ShipmentId { get; set; }
        public string ShipperName { get; set; }
        public string CarrierName { get; set; }
        public decimal ShipmentWeight { get; set; }
        public string ShipmentDescription { get; set; }
        public string ShipmentRateDescription { get; set; }
    }
}
