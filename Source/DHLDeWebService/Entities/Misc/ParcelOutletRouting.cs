using DHLDeWebService.Attributes;
using System.ComponentModel;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace DHLDeWebService.Entities.Misc
{
    [System.Serializable]
    public class ParcelOutletRouting : DHLServiceBaseType
    {
        /// <summary>
        /// Email address of the recipient. If more than 70 characters are entered, the E-Mail address is automatically shortened and transferred.
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "70"),
            ServiceValidation(ServiceValidationAttribute.ValidationRule.Regex, Constants.EmailValidationRegex),
            Required, XmlAttribute]
        public string details { get; set; }

        
    }
}