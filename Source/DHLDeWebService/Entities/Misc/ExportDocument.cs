using DHLDeWebService.Attributes;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DHLDeWebService.Entities.Misc
{
    [Serializable]
    public class ExportDocument 
    {
        /// <summary>
        /// In case invoice has a number, client app can provide it in this field.
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "35")]
        public string invoiceNumber { get; set; } = "";
        /// <summary>
        /// depends on chosen product -> only mandatory for international, non EU shipments
        /// </summary>
        [AcceptedValues("OTHER", "PRESENT", "COMMERCIAL_SAMPLE", "DOCUMENT", "RETURN_OF_GOODS"), Required]
        public string exportType { get; set; } = "";
        /// <summary>
        /// Description mandatory if ExportType is OTHER.
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MinLength, "1"),
            ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "256")]
        public string ExportTypeDescription { get; set; } = "";
        /// <summary>
        /// Element provides terms of trades, incoterms codes: DDP (Delivery Duty Paid) DXV (Delivery duty paid (excl. VAT )) DDU (DDU - Delivery Duty Paid) DDX (Delivery duty paid (excl. Duties, taxes and VAT) are vaild values.
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.Length, "3"),
            AcceptedValues("DDP","DXV","DDU","DDX")]
        public string termsOfTrade { get; set; } = "";
        /// <summary>
        /// PlaceOfCommital is a Locaton
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "35"), Required]
        public string placeOfCommital { get; set; } = "";
        /// <summary>
        /// Additional custom fees to be payed.
        /// </summary>
        public decimal additionalFee { get; set; }
        /// <summary>
        /// The permit number.
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "10")]
        public string permitNumber { get; set; } = "";
        /// <summary>
        /// The attestation number.
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "35")]
        public string attestationNumber { get; set; } = "";
        /// <summary>
        /// Sets an electronic export notification.
        /// </summary>
        [ValidateObject]
        public DHLServiceBaseType WithElectronicExportNtfctn { get; set; }
        /// <summary>
        /// One or more child elements for every position to be defined within the Export Document. 
        /// Each one contains description, country code of origin, amount, net weight, customs value. 
        /// Multiple positions only possible for international shipments, other than EU shipments.
        /// </summary>
        [ValidateObject]
        public ExportDocPosition ExportDocPosition { get; set; }

        
    }
}