using DHLDeWebService.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DHLDeWebService.Entities.Misc
{
    [XmlRoot(Namespace = "")]
    [System.Serializable]
    public class ShipmentOrder 
    {
        /// <summary>
        /// Free field to to tag multiple shipment orders individually by client. 
        /// Essential for later mapping of response data returned by webservice upon createShipment operation.
        /// Allows client to assign the shipment information of the response to the correct shipment order of the request.
        /// </summary>
        public long sequenceNumber { get; set; }
        /// <summary>
        /// Is the core element of a ShipmentOrder. It contains all relevant information of the shipment.
        /// </summary>
        [ValidateObject]
        public Shipment Shipment { get;set; }
        /// <summary>
        /// If set to true (=1), the label will be only be printable, if the receiver address is valid.
        /// </summary>
        [ValidateObject]
        public DHLServiceBaseType PrintOnlyIfCodeable { get; set; } = new DHLServiceBaseType();
        /// <summary>
        /// Dial to determine label ouput format.
        /// Must be either 'URL' or 'B64' = Base64encoded: it is possible to request an URL for receiving the label as PDF stream, or to request the label as base64encoded binary data directly. 
        /// If not defined by client, web service defaults to 'URL'.
        /// </summary>
        [AcceptedValues("URL", "B64"), ValidateObject]
        public string labelResponseType { get; set; } = "";

        
    }
}
