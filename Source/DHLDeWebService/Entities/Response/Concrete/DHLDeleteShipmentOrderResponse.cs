using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DHLDeWebService.Entities.Response.Concrete
{
    [Serializable]
    public class DHLDeleteShipmentOrderResponse
    {
        [XmlElement(ElementName = "DeleteShipmentOrderResponse", Namespace = "http://dhl.de/webservices/businesscustomershipping")]
        public DeleteShipmentOrderResponse DeleteShipmentOrderResponse { get; set; }
    }
}
