using DHLDeWebService.Attributes;
using System.ComponentModel;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace DHLDeWebService.Entities.Misc
{
    [System.Serializable]
    public class DeliveryTimeframe : DHLServiceBaseType
    {
        /// <summary>
        /// Timeframe of delivery, if the option is used: ValidValues are 10001200: 10:00 until 12:00; 12001400: 12:00 until 14:00 14001600: 14:00 until 16:00; 16001800: 16:00 until 18:00 18002000: 18:00 until 20:00; 19002100: 19:00 until 21:00
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.Length, "8"),
            AcceptedValues("10001200", "12001400", "14001600", "16001800", "18002000", "19002100"),
            Required, XmlAttribute]
        public string type { get; set; }
    }
}