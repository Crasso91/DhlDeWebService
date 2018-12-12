using DHLDeWebService.Attributes;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DHLDeWebService.Entities.Misc
{
    [Serializable]
    public class Notification 
    {
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "70"), 
            ServiceValidation(ServiceValidationAttribute.ValidationRule.Regex, Constants.EmailValidationRegex),
            Required]
        public string recipientEmailAddress { get; set; } = "";

        
    }
}