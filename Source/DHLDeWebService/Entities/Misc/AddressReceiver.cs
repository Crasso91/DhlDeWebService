using DHLDeWebService.Attributes;
using System.ComponentModel;

namespace DHLDeWebService.Entities.Misc
{
    [System.Serializable]
    public class AddressReceiver : Address
    {
        /// <summary>
        /// Name of company (second part).
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "35")]
        public string name2 { get; set; } = "";
        /// <summary>
        /// Name of company (third part).
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "35")]
        public string name3 { get; set; } = "";

    }
}