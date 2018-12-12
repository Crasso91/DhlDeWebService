using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DHLDeWebService.Entities.Request.Concrete
{
    [Serializable]
    public class DHLGetLabelRequest
    {
        [XmlElement(Namespace = "http://dhl.de/webservices/businesscustomershipping")]
        public GetLabelRequest GetLabelRequest { get; set; } = new GetLabelRequest();
    }
}
