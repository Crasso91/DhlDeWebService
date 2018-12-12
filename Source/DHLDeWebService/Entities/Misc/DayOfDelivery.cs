using DHLDeWebService.Attributes;
using System.ComponentModel;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace DHLDeWebService.Entities.Misc
{
    [System.Serializable]
    public class DayOfDelivery : DHLServiceBaseType
    {
        /// <summary>
        /// Day of Delivery, if the option is used: Date in format yyyy-mm-dd
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.Length, "10"),
            ServiceValidation(ServiceValidationAttribute.ValidationRule.Regex, Constants.DateValidationRegex),
            Required, XmlAttribute]
        public string details { get; set; }
    }
}