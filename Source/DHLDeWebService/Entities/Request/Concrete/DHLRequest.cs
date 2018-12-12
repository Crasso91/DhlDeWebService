using DHLDeWebService.Attributes;
using DHLDeWebService.Entities.Misc;
using DHLDeWebService.Entities.Request.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DHLDeWebService.Entities.Request.Concrete
{
    [XmlRoot(Namespace="http://schemas.xmlsoap.org/soap/envelope/", IsNullable = false, ElementName = "Envelope")]
    [System.Serializable]
    public class DHLRequest<T> : IDHLRequest where T : new()
    {
        [XmlElement(Namespace = "http://schemas.xmlsoap.org/soap/envelope/"), ValidateObject]
        public DHLHeader Header { get; set; } = new DHLHeader();
        [XmlElement(Namespace = "http://schemas.xmlsoap.org/soap/envelope/"), ValidateObject]
        public T Body { get; set; } = new T();
    }
}
