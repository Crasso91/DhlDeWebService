using DHLDeWebService.Attributes;
using System;
using System.ComponentModel;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace DHLDeWebService.Entities.Misc
{
    [Serializable]
    public class Name 
    {
        /// <summary>
        /// Name of receiver (first part)
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "35"), Required, XmlElement(Namespace = "http://dhl.de/webservice/cisbase")]
        public string name1 { get; set; } = "";
        /// <summary>
        /// Name of company (second part).
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "35"), XmlElement(Namespace = "http://dhl.de/webservice/cisbase")]
        public string name2 { get; set; } = "";
        /// <summary>
        /// Name of company (third part).
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "35"), XmlElement(Namespace = "http://dhl.de/webservice/cisbase")]
        public string name3 { get; set; } = "";

        
    }
}