using DHLDeWebService.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DHLDeWebService.Attributes.ServiceValidationAttribute;

namespace DHLDeWebService.Entities.Misc
{
    [Serializable]
    public class OperationState 
    {
        /// <summary>
        /// Identifier for ShipmentOrder set by client application in CreateShipment request. 
        /// The defined value is looped through and returned unchanged by the web service within the response of createShipment. 
        /// The client can therefore assign the status information of the response to the correct ShipmentOrder of the request.
        /// </summary>
        [ServiceValidation(ValidationRule.MaxLength, "30")]
        public string sequenceNumber { get; set; } = "";
        /// <summary>
        /// For successful operations, a shipment number is created and returned. Depending on the invoked product.
        /// </summary>
        [ValidateObject]
        public LabelData LabelData { get; set; }

        
    }
}
