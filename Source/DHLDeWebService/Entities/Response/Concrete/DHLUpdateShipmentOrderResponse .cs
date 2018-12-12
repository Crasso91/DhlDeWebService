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
    public class DHLUpdateShipmentOrderResponse
    {
        [XmlElement(ElementName = "UpdateShipmentOrderResponse", Namespace = "http://dhl.de/webservices/businesscustomershipping")]
        public UpdateShipmentOrderResponse UpdateShipmentOrderResponse { get; set; }
    }
}
