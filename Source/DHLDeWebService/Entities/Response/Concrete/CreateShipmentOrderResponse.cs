using DHLDeWebService.Entities.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DHLDeWebService.Entities.Response.Concrete
{
    public class CreateShipmentOrderResponse
    {
        /// <summary>
        /// The version of the webservice implementation for which the requesting client is developed.
        /// </summary>
        [XmlElement(Namespace = "http://dhl.de/webservices/businesscustomershipping")]
        public DHLVersion Version { get; set; }
        /// <summary>
        /// Success status after processing the overall request.
        /// </summary>
        [XmlElement(Namespace = "")]
        public Status Status { get; set; }
        /// <summary>
        /// The operation's success status for every single ShipmentOrder will be returned by one CreationState element. It is identifiable via SequenceNumber.
        /// </summary>
        [XmlElement(Namespace = "")]
        public OperationState CreationState { get; set; }
    }
}
