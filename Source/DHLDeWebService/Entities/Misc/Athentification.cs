using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLDeWebService.Entities.Misc
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://dhl.de/webservice/cisbase")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://dhl.de/webservice/cisbase", IsNullable = false)]
    [Serializable]
    public partial class Authentification 
    {
        public string user { get; set; } = "";
        public string signature { get; set; } = "";

        
    }

}
