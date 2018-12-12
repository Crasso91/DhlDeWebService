using DHLDeWebService.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static DHLDeWebService.Attributes.ServiceValidationAttribute;

namespace DHLDeWebService.Entities.Misc
{
    [Serializable] 
    public class ShipmentDetail 
    {
        /// <summary>
        /// Determines the DHL Paket product to be ordered.
        /// V01PAK: DHL PAKET; V53WPAK: DHL PAKET International; V54EPAK: DHL Europaket; V06PAK: DHL PAKET Taggleich; V06TG: Kurier Taggleich; V06WZ: Kurier Wunschzeit; V86PARCEL: DHL PAKET Austria; V87PARCEL: DHL PAKET Connect; V82PARCEL: DHL PAKET International
        /// </summary>
        [AcceptedValues("V01PAK", "V53WPAK", "V54EPAK", "V06PAK", "V06TG", "V06WZ", "V86PARCEL", "V87PARCEL", "V82PARCEL")]
        public string product { get; set; } = "";
        /// <summary>
        /// DHL account number (14 digits).
        /// </summary>
        [ServiceValidation(ValidationRule.MaxLength, "14"), Required, XmlElement(Namespace = "http://dhl.de/webservice/cisbase")]
        public string accountNumber { get; set; } = "";
        /// <summary>
        /// A reference number that the client can assign for better association purposes. Appears on shipment label.
        /// </summary>
        [ServiceValidation(ValidationRule.MaxLength, "35")]
        public string customerReference { get; set; } = "";
        /// <summary>
        /// Date of shipment should be close to current date and must not be in the past. Iso format required: yyyy-mm-dd.
        /// </summary>
        [ServiceValidation(ValidationRule.MaxLength, "10"), Required]
        public string shipmentDate { get; set; } = "";
        /// <summary>
        /// DHL account number (14 digits).
        /// </summary>
        [ServiceValidation(ValidationRule.MaxLength, "14")]
        public string returnShipmentAccountNumber { get; set; } = "";
        /// <summary>
        /// A reference number that the client can assign for better association purposes. Appears on return shipment label.
        /// </summary>
        [ServiceValidation(ValidationRule.MaxLength, "35")]
        public string ReturnShipmentReference { get; set; } = "";
        /// <summary>
        /// For every parcel specified, contains weight in kg, length in cm, width in cm and height in cm.
        /// </summary>
        [Required, ValidateObject]
        public ShipmentItem ShipmentItem { get; set; } = new ShipmentItem();
        /// <summary>
        /// Use one dedicated Service node for each service to be booked with the shipment product. 
        /// Add another Service node for booking a further service and so on. 
        /// Successful booking of a particular service depends on account permissions and product's service combinatorics. 
        /// I.e. not every service is allowed for every product, or can be combined with all other allowed services. 
        /// The service bundles that contain all services are the following.
        /// </summary>
        /// 
        [ValidateObject]
        public DHLService Service { get; set; }
        [ValidateObject]
        public Notification Notification { get; set; } = new Notification();
        [ValidateObject]
        public BankData BankData { get; set; }

        
    }
}
