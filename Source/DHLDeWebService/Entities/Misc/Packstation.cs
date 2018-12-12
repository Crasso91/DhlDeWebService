using DHLDeWebService.Attributes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DHLDeWebService.Entities.Misc
{
    [System.Serializable]
    public class Packstation : AddressBaseType
    {
        /// <summary>
        /// Post Number of the receiver
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MinLength, "1"),
            ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "10"),
            Required]
        public string postNumber { get; set; } = "";
        /// <summary>
        /// Number of the Packstation.
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.Length, "3"), Required]
        public string packstationNumber { get; set; } = "";

        
    }
}