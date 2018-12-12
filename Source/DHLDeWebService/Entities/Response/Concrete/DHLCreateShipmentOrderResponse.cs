using DHLDeWebService.Entities.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DHLDeWebService.Entities.Response.Concrete
{
    [Serializable]
    public class DHLCreateShipmentOrderResponse
    {
        [XmlElement(ElementName = "CreateShipmentOrderResponse", Namespace = "http://dhl.de/webservices/businesscustomershipping")]
        public CreateShipmentOrderResponse CreateShipmentOrderResponse { get; set; }
    }
}
