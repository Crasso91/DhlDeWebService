using DHLDeWebService.Attributes;
using System.ComponentModel;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace DHLDeWebService.Entities.Misc
{
    [System.Serializable]
    public class Endorsement : DHLServiceBaseType
    {
        /// <summary>
        /// Service endorsement is used to specify handling if recipient not met There are the following types are allowed: 
        /// For Germany: SOZU (Return immediately), ZWZU (2nd attempt of Delivery); 
        /// for International: IMMEDIATE (Sending back immediately to sender), AFTER_DEADLINE (Sending back immediately to sender after expiration of time), ABANDONMENT (Abandonment of parcel at the hands of sender (free of charge))
        /// </summary>
        [AcceptedValues("SOZU", "ZWZU", "IMMEDIATE", "AFTER_DEADLINE", "ABANDONMENT"), Required, XmlAttribute]
        public string type { get; set; }

    }
}
