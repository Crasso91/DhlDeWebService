using DHLDeWebService.Attributes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DHLDeWebService.Entities.Misc
{
    [System.Serializable]
    public class Postfiliale : AddressBaseType
    {
        /// <summary>
        /// Number of the postfiliale
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.Length, "3"), Required]
        public string postfilialNumber { get; set; } 
        /// <summary>
        /// No mandatory field, if you use the Email Address in this field.
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MinLength, "1"), 
            ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "10")]
        public string postNumber { get; set; }

        
    }
}