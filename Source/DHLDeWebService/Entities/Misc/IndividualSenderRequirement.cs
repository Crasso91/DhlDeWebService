using DHLDeWebService.Attributes;
using System;
using System.ComponentModel;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace DHLDeWebService.Entities.Misc
{
    [System.Serializable]
    public class IndividualSenderRequirement : DHLServiceBaseType
    {
        /// <summary>
        /// Individual details for handling (freetext)
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MinLength, "1"),
            ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "250"),
            Required, XmlAttribute]
        public string detail { get; set; }

        
    }
}