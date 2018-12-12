using DHLDeWebService.Attributes;
using System.ComponentModel;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace DHLDeWebService.Entities.Misc
{
    [System.Serializable]
    public class PreferredDay : DHLServiceBaseType
    {
        /// <summary>
        /// Preferred Day, if the option is used: Date in format yyyy-mm-dd
        /// Choose a preferred day that lies between 2 and 6 work days after the shipment date.The day may not be a holiday or Sunday.
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.Length, "10"),
            ServiceValidation(ServiceValidationAttribute.ValidationRule.Regex, Constants.DateValidationRegex),
            Required, XmlAttribute]
        public string details { get; set; }

        
    }
}