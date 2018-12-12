using DHLDeWebService.Attributes;
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace DHLDeWebService.Entities.Misc
{
    [Serializable]
    public class Communication 
    {
        /// <summary>
        /// Phone number.
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "35"), XmlElement(Namespace = "http://dhl.de/webservice/cisbase")]
        public string phone { get; set; } = "";
        /// <summary>
        /// E-Mail address of the shipper.
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "70"),
            ServiceValidation(ServiceValidationAttribute.ValidationRule.Regex, Constants.EmailValidationRegex), XmlElement(Namespace = "http://dhl.de/webservice/cisbase")]
        public string email { get; set; } = "";
        /// <summary>
        /// First name and last name of contact person.
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "35"), XmlElement(Namespace = "http://dhl.de/webservice/cisbase")]
        public string contactPerson { get; set; } = "";

        
    }
}