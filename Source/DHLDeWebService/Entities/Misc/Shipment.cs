using DHLDeWebService.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace DHLDeWebService.Entities.Misc
{
    [Serializable]
    public class Shipment 
    {
        /// <summary>
        /// Contains the information of the shipment product code, weight and size characteristics and services to be used.
        /// </summary>
        [Required, XmlElement("ShipmentDetails"), ValidateObject]
        public List<ShipmentDetail> ShipmentDetails { get; set; } = new List<ShipmentDetail>();
        /// <summary>
        /// Contains relevant information about the Shipper.
        /// </summary>
        [Required, ValidateObject]
        public Shipper Shipper { get; set; }
        /// <summary>
        /// Contains relevant information about Receiver.
        /// </summary>
        [Required, ValidateObject]
        public Receiver Receiver { get; set; }
        /// <summary>
        /// To be used if a return label address shall be generated.
        /// </summary>
        [Required, ValidateObject]
        public ReturnReceiver ReturnReceiver { get; set; }
        /// <summary>
        /// For international shipments, this section contains information about the exported goods relevant for customs. 
        /// For international shipments: commercial invoice, dispatch note (CP71) and customs declaration (CN23) are printed into returned label information.
        /// Data is also transferred as electronic declaration to customs. For european shipments. For international shipments, ExportDocument can contain one or more positions in child element.
        /// </summary>
        [ValidateObject]
        public ExportDocument ExportDocument { get; set; }

        
    }
}
