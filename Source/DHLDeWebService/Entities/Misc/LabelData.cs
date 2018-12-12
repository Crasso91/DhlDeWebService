using DHLDeWebService.Attributes;
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace DHLDeWebService.Entities.Misc
{
    [Serializable]
    public class LabelData 
    {
        /// <summary>
        /// Success status of processing retrieval of particular shipment label.
        /// </summary>
        [ValidateObject]
        public Status Status { get; set; }
        /// <summary>
        /// Can contain any DHL shipmentnumber.
        /// </summary>
        [XmlElement(Namespace = "http://dhl.de/webservice/cisbase"), ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "39")]
        public string shipmentNumber { get; set; } = "";
        /// <summary>
        /// If label output format was requested as 'URL' via LabelResponseType, this element will be returned. 
        /// It contains the URL to access the PDF label. This is default output format if not specified other by client in labelResponseType. 
        /// Depending on setting in customer profile all labels or just the shipmentlabel.
        /// </summary>
        public string labelUrl { get; set; } = "";
        /// <summary>
        ///	Label as base64 encoded pdf data, depending on setting in customer profile all labels or just the shipmentlabel.
        /// </summary>
        public string labelData { get; set; } = "";
        /// <summary>
        /// Label as base64 encoded pdf data, depending on setting in customer profile all labels or just the returnshipmentlabel.
        /// </summary>
        public string returnLabelUrl { get; set; } = "";
        /// <summary>
        /// Label as base64 encoded pdf data, depending on setting in customer profile all labels or just the returnshipmentlabel.
        /// </summary>
        public string returnLabelData { get; set; } = "";
        /// <summary>
        /// If label output format was requested as 'URL' via LabelResponseType, this element will be returned. It contains the URL to access the PDF label. 
        /// This is default output format if not specified other by client in labelResponseType. Depending on setting in customer profile all labels or just the export documents.
        /// </summary>
        public string exportLabelUrl { get; set; } = "";
        /// <summary>
        /// Label as base64 encoded pdf data, depending on setting in customer profile all labels or just the export documents.
        /// </summary>
        public string exportLabelData { get; set; } = "";
        /// <summary>
        /// If label output format was requested as 'URL' via LabelResponseType, this element will be returned. 
        /// It contains the URL to access the PDF label. 
        /// This is default output format if not specified other by client in labelResponseType. 
        /// Depending on setting in customer profile all labels or just the cod related documents.
        /// </summary>
        public string codLabelUrl { get; set; } = "";
        /// <summary>
        /// Label as base64 encoded pdf data, depending on setting in customer profile all labels or just the cod related documents.
        /// </summary>
        public string codLabelData { get; set; } = "";

        
    }
}