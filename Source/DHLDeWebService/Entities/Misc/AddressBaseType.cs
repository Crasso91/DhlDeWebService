using DHLDeWebService.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace DHLDeWebService.Entities.Misc
{
    [Serializable]
    public class AddressBaseType 
    {
        /// <summary>
        /// Type of zip code
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "10"),
            ServiceValidation(ServiceValidationAttribute.ValidationRule.Regex, Constants.ZipCodeValidationRegex),
            Required, XmlElement(Namespace = "http://dhl.de/webservice/cisbase")]
        public string zip { get; set; } = "";
        /// <summary>
        /// City name.
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "10"), Required, XmlElement(Namespace = "http://dhl.de/webservice/cisbase")]
        public string city { get; set; } = "";
        /// <summary>
        /// Country.
        /// </summary>
        [XmlElement(Namespace = "http://dhl.de/webservice/cisbase"), ValidateObject]
        public Origin Origin { get; set; } = new Origin();

        
    }
}
