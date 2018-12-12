using DHLDeWebService.Attributes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace DHLDeWebService.Entities.Misc
{
    [System.Serializable]
    public class AdditionalInsurance : DHLServiceBaseType
    {
        /// <summary>
        /// Amount insured
        /// </summary>
        [Required, XmlAttribute]
        public decimal insuranceAmount { get; set; }
    }

}