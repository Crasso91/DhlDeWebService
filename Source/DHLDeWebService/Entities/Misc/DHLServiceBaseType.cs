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
    public class DHLServiceBaseType 
    {
        /// <summary>
        /// Indicates, if the option is on/off
        /// </summary>
        [AcceptedValues("0", "1"), Required, XmlAttribute]
        public int active { get; set; }

        
    }
}
