﻿using DHLDeWebService.Attributes;
using System.ComponentModel;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace DHLDeWebService.Entities.Misc
{
    [System.Serializable]
    public class PreferredNeighbour : DHLServiceBaseType
    {
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MinLength, "1"), 
            ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "100"),
            Required, XmlAttribute]
        public string details { get; set; }

        
    }
}