using DHLDeWebService.Attributes;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DHLDeWebService.Entities.Misc
{
    [Serializable]
    public class ExportDocPosition 
    {
        /// <summary>
        /// Description of the unit / position
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "256"),Required]
        public string description { get; set; } = "";
        /// <summary>
        /// Country's ISO-Code (ISO-2- Alpha) of the unit / position
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.Length, "2"),
            ServiceValidation(ServiceValidationAttribute.ValidationRule.Regex, Constants.ISOValidationRegex),
            Required]
        public string countryCodeOrigin { get; set; } = "";
        /// <summary>
        /// Customs tariff number of the unit / position
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "10"),Required]
        public string customsTariffNumber { get; set; } = "";
        /// <summary>
        /// Quantity of the unit / position
        /// </summary>
        public int amount { get; set; }
        /// <summary>
        /// Net weight of the unit / position.
        /// </summary>
        public decimal netWeightInKG { get; set; }
        /// <summary>
        /// customs value amount of the unit / position
        /// </summary>
        public decimal customsValue { get; set; }

        
    }
}