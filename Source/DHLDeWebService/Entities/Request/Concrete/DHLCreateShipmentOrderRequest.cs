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
    [Serializable]
    public class DHLCreateShipmentOrderRequest
    {
        [XmlElement(Namespace = "http://dhl.de/webservices/businesscustomershipping"), ValidateObject]
        public CreateShipmentOrderRequest CreateShipmentOrderRequest { get; set; } = new CreateShipmentOrderRequest();
    }

}
