using DHLDeWebService.Attributes;
using System;
using System.ComponentModel;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace DHLDeWebService.Entities.Misc
{
    [Serializable]
    public class BankData 
    {
        /// <summary>
        /// Name of bank account owner.
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "81"), Required, XmlElement(Namespace = "http://dhl.de/webservice/cisbase")]
        public string accountOwner { get; set; } = "";
        /// <summary>
        /// Name of bank.
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "81"), Required, XmlElement(Namespace = "http://dhl.de/webservice/cisbase")]
        public string bankName { get; set; } = "";
        /// <summary>
        /// IBAN code of bank account.
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "34"), Required, XmlElement(Namespace = "http://dhl.de/webservice/cisbase")]
        public string iban { get; set; } = "";
        /// <summary>
        /// Purpose of bank information.
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "35"),
            ServiceValidation(ServiceValidationAttribute.ValidationRule.Regex, Constants.IBANValidationRegex), XmlElement(Namespace = "http://dhl.de/webservice/cisbase")]
        public string note1 { get; set; } = "";
        /// <summary>
        /// Purpose of bank information.
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "35"), XmlElement(Namespace = "http://dhl.de/webservice/cisbase")]
        public string note2 { get; set; } = "";
        /// <summary>
        /// Bank-Information-Code (BankCCL) of bank account.
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "11"), XmlElement(Namespace = "http://dhl.de/webservice/cisbase")]
        public string bic { get; set; } = "";
        /// <summary>
        /// Accountreferece to customer profile
        /// </summary>
        [ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "35"), XmlElement(Namespace = "http://dhl.de/webservice/cisbase")]
        public string accountreference { get; set; } = "";

        
    }
}