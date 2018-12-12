using DHLDeWebService.Attributes;
using DHLDeWebService.Entities.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DHLDeWebService.Entities.Request.Concrete
{

    [Serializable, XmlRoot(Namespace = "http://dhl.de/webservices/businesscustomershipping")]
    public class CreateShipmentOrderRequest
    {
        [XmlElement(Namespace = "http://dhl.de/webservices/businesscustomershipping"), ValidateObject]
        public DHLVersion Version { get; set; } = new DHLVersion();
        [XmlElement("ShipmentOrder", Namespace = ""), ValidateObject]
        public List<ShipmentOrder> ShipmentOrder { get; set; } = new List<ShipmentOrder>();
    }
}
