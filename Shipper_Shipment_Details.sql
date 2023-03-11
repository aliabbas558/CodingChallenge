CREATE PROCEDURE Shipper_shipment_details @shipper_id INT
AS
  BEGIN
      SELECT shipment_id,
             shipper_name,
             carrier_name,
             shipment_description,
             shipment_weight,
             [shipment_rate_description]
      FROM   dbo.shipper shipper
             INNER JOIN [dbo].[shipment] shipment
                     ON shipper.shipper_id = shipment.shipper_id
             INNER JOIN dbo.carrier carrier
                     ON carrier.carrier_id = shipment.carrier_id
             INNER JOIN [dbo].[shipment_rate] rate
                     ON rate.[shipment_rate_id] = shipment.[shipment_rate_id]
      WHERE  shipper.shipper_id = @shipper_id
  END

EXEC Shipper_shipment_details
  @shipper_id = 1 