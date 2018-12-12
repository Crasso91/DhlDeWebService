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
    public class GetLabelResponse
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
        /// For successful operations, a shipment number is created and returned. Depending on the invoked product.
        /// </summary>
        [XmlElement(Namespace = "")]
        public LabelData LabelData { get; set; }
    }
}
