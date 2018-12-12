using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DHLDeWebService.Entities.Response.Concrete
{
    public class DHLGetLabelResponse
    {
        [XmlElement(ElementName = "GetLabelResponse", Namespace = "http://dhl.de/webservices/businesscustomershipping")]
        public GetLabelResponse GetLabelResponse { get; set; }
    }
}
