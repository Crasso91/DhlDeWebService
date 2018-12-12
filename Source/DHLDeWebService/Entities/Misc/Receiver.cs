using DHLDeWebService.Attributes;
using System;
using System.ComponentModel;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace DHLDeWebService.Entities.Misc
{
    [Serializable]
    public class Receiver 
    {
        /// <summary>
        /// Name of receiver (first part)
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "35"), Required, XmlElement(Namespace = "http://dhl.de/webservice/cisbase")]
        public string name1 { get; set; } = "";
        /// <summary>
        /// Information about communication.
        /// </summary>
        [ValidateObject]
        public Communication Communication { get; set; } = new Communication();
        /// <summary>
        /// The address data of the receiver.
        /// </summary>
        [Required, ValidateObject]
        public AddressReceiver Address { get; set; } = new AddressReceiver();
        /// <summary>
        /// The address of the receiver is a german Packstation.
        /// </summary>
        [Required, ValidateObject]
        public Packstation Packstation { get; set; }
        /// <summary>
        /// The address of the receiver is a german Postfiliale.
        /// </summary>
        [Required, ValidateObject]
        public Postfiliale Postfiliale { get; set; }
        /// <summary>
        /// The address of the receiver is a european Parcelshop.
        /// </summary>
        [Required, ValidateObject]
        public ParcelShop ParcelShop { get; set; }

        
    }
}