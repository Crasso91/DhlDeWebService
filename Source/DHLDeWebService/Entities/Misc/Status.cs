using DHLDeWebService.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DHLDeWebService.Entities.Misc
{
    [System.Serializable]
    public class Status 
    {
        /// <summary>
        /// Overall status of the entire request: A value of zero means, the request was processed without error. A value greater than zero indicates that an error occurred. The detailed mapping and explanation of returned status codes is contained in the list.
        /// </summary>
        public int statusCode { get; set; }
        /// <summary>
        /// Explanation of the statuscode and potential errors.
        /// </summary>
        public string statusText { get; set; }
        /// <summary>
        /// Explanation of the statuscode and potential errors.
        /// </summary>
        [XmlElement(ElementName = "statusMessage"), ValidateObject]
        public List<string> StatusMessage { get; set; }

        
    }
}
