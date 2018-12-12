using DHLDeWebService.Attributes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DHLDeWebService.Entities.Misc
{
    [System.Serializable]
    public class Origin 
    {
        /// <summary>
        /// Name of country.
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "30")]
        public string country { get; set; } = "Deutschland";
        /// <summary>
        /// Country's ISO-Code (ISO-2-Alpha).
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.Length, "2"),
            ServiceValidation(ServiceValidationAttribute.ValidationRule.Regex, Constants.ISOValidationRegex),
            Required]
        public string countryISOCode { get; set; } = "DE";
        /// <summary>
        /// 	Name of state.
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "30")]
        public string state { get; set; } = "?";

        
    }

}