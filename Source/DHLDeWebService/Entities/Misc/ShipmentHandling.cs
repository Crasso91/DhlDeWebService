using DHLDeWebService.Attributes;
using System.ComponentModel;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace DHLDeWebService.Entities.Misc
{
    [System.Serializable]
    public class ShipmentHandling : DHLServiceBaseType
    {
        /// <summary>
        /// Type of shipment handling. There are the following types are allowed: 
        /// a: Remove content, return box; 
        /// b: Remove content, pick up and dispose cardboard packaging; 
        /// c: Handover parcel/box to customer ¿ no disposal of cardboar.d/box; 
        /// d: Remove bag from of cooling unit and handover to customer; 
        /// e: Remove content, apply return label und seal box, return box
        /// </summary>
        [AcceptedValues("a", "b", "c", "d", "e"),
            ServiceValidation(ServiceValidationAttribute.ValidationRule.Length, "1"),
            Required, XmlAttribute]
        public string type { get; set; }

        
    }
}