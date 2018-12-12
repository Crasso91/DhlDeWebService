using DHLDeWebService.Attributes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DHLDeWebService.Entities.Misc
{
    [System.Serializable]
    public class Ident 
    {
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MinLength, "0"), 
            ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "255"),
            Required]
        public string surname { get;  set; } = "";
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MinLength,"0"),
            ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "255"),
            Required]
        public string givenName { get; set; } = "";
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.Length, "10"),
            ServiceValidation(ServiceValidationAttribute.ValidationRule.Regex, Constants.DateValidationRegex),
            Required]
        public string dateofBirth { get; set; } = "";
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MinLength,"1"),
            ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "3"),
            ServiceValidation(ServiceValidationAttribute.ValidationRule.Regex, Constants.OnlyNumbersValidationRegex),
            Required]
        public string minimumAge { get; set; } = "";

        
    }
}