using DHLDeWebService.Attributes;
using DHLDeWebService.Entities.Misc;
using System;
using System.Xml.Serialization;

namespace DHLDeWebService.Entities.Request.Concrete
{
   
    [Serializable, XmlRoot(Namespace = "http://dhl.de/webservices/businesscustomershipping")]
    public class DeleteShipmentOrderRequest
    {
        [XmlElement(Namespace = "http://dhl.de/webservices/businesscustomershipping")]
        public DHLVersion Version { get; set; } = new DHLVersion();
        [XmlElement("shipmentNumber", Namespace = "http://dhl.de/webservice/cisbase"), ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "39")]
        public string shipmentNumber { get; set; }
    }
}