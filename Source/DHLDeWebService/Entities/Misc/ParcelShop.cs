using DHLDeWebService.Attributes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DHLDeWebService.Entities.Misc
{
    [System.Serializable]
    public class ParcelShop : AddressBaseType
    {
        /// <summary>
        /// Number of the ParcelShop
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.Length, "3"), Required]
        public string parcelShopNumber { get; set; } 
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "35"),Required]
        public string streetName { get; set; }
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "5"), Required]
        public string streetNumber { get; set; }

        
    }
}