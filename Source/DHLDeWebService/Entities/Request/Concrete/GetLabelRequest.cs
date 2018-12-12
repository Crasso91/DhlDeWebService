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
    public class GetLabelRequest
    {
        [XmlElement(Namespace = "http://dhl.de/webservices/businesscustomershipping")]
        public DHLVersion Version { get; set; } = new DHLVersion();
        [XmlElement("shipmentNumber", Namespace = "http://dhl.de/webservice/cisbase"), ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "39")]
        public string shipmentNumber { get; set; }
        [XmlElement("labelResponseType", Namespace = ""), AcceptedValues("B64", "URL")]
        public string labelResponseType { get; set; }
    }
}
