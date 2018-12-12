using DHLDeWebService.Attributes;
using System.ComponentModel;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace DHLDeWebService.Entities.Misc
{
    [System.Serializable]
    public class CashOnDelivery : DHLServiceBaseType
    {
        /// <summary>
        /// Configuration whether the transmission fee to be added to the COD amount or not by DHL. Select the option then the new COD amount will automatically printed on the shipping label and will transferred to the end of the day to DHL.
        /// Do not select the option and the specified COD amount remains unchanged.
        /// </summary>
        [AcceptedValues("0","1"), Required, ServiceValidation(ServiceValidationAttribute.ValidationRule.Length, "1"), XmlAttribute]
        public string addFee { get; set; } 
        [Required, XmlAttribute]
        public decimal codAmount { get; set; }
    }
}