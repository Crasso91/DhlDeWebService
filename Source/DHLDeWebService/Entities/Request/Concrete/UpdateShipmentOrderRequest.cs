﻿using DHLDeWebService.Attributes;
using DHLDeWebService.Entities.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DHLDeWebService.Entities.Request.Concrete
{

    [Serializable, XmlRoot(Namespace = "http://dhl.de/webservices/businesscustomershipping")]
    public class UpdateShipmentOrderRequest
    {
        [XmlElement(Namespace = "http://dhl.de/webservices/businesscustomershipping")]
        public DHLVersion Version { get; set; } = new DHLVersion();
        [XmlElement(Namespace = "http://dhl.de/webservice/cisbase"), ServiceValidation(ServiceValidationAttribute.ValidationRule.MaxLength, "39")]
        public string shipmentNumber { get; set; } = "";
        [XmlElement("ShipmentOrder", Namespace = "")]
        public List<ShipmentOrder> ShipmentOrder { get; set; } = new List<ShipmentOrder>();
    }
}
