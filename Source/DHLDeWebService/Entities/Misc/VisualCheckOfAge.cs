using DHLDeWebService.Attributes;
using System.ComponentModel;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace DHLDeWebService.Entities.Misc
{
    [System.Serializable]
    public class VisualCheckOfAge : DHLServiceBaseType
    {
        /// <summary>
        /// 	Service VisualCheckOfAge is used to specify the minimum age of the recipient There are the following types are allowed: A16 A18
        /// </summary>
        [AcceptedValues("A16", "A18"), Required,
            ServiceValidation(ServiceValidationAttribute.ValidationRule.Length, "3"), XmlAttribute]
        public string type { get; set; } 
    }
}