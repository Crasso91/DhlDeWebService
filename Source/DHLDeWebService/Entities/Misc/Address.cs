using DHLDeWebService.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace DHLDeWebService.Entities.Misc
{
    [Serializable]
    public class Address : AddressBaseType
    {
        public Address()
        {
            addressAddition = new List<string> { "?" };
        }

        /// <summary>
        /// Name of street.
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "35"), Required, XmlElement(Namespace = "http://dhl.de/webservice/cisbase")]
        public string streetName { get; set; } = "";
        /// <summary>
        /// House number.
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "5"), Required, XmlElement(Namespace = "http://dhl.de/webservice/cisbase")]
        public string streetNumber { get; set; } = "1";
        /// <summary>
        /// Address addon This field is used for international shipping.
        /// https://entwickler.dhl.de/documents/10156/244108/20170301_Address_Structures_in_SHIP.pdf/b74c42ed-aa61-43b8-8030-cd72d101cd92
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxOccurrence, "2"), XmlElement(Namespace = "http://dhl.de/webservice/cisbase", ElementName = "addressAddition")]
        public List<string> addressAddition { get; set; } 
        /// <summary>
        /// DispatchingInformation. This field is used for international shipping
        /// https://entwickler.dhl.de/documents/10156/244108/20170301_Address_Structures_in_SHIP.pdf/b74c42ed-aa61-43b8-8030-cd72d101cd92
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "35"), XmlElement(Namespace = "http://dhl.de/webservice/cisbase")]
        public string dispatchingInformation {get;set;} = "?";
    }
}