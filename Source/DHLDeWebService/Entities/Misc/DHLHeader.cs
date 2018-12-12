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
    [System.Serializable]
    public class DHLHeader 
    {
        [XmlIgnore]
        public string SOAPAction { get; set; }
        [System.Xml.Serialization.XmlElement(Namespace = "http://dhl.de/webservice/cisbase"), ValidateObject]
        public Authentification Authentification { get; set; } = new Authentification();

        
    }
}
