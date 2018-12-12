using DHLDeWebService.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static DHLDeWebService.Attributes.ServiceValidationAttribute;

namespace DHLDeWebService.Entities.Misc
{

    [Serializable]
    public class DHLVersion 
    {
        [ServiceValidation(ValidationRule.MaxLength, "2")]
        [XmlElement(Namespace = "")]
        public int majorRelease { get; set; } = 2;
        [ServiceValidation(ValidationRule.MaxLength, "2")]
        [XmlElement(Namespace = "")]
        public int minorRelease { get; set; } = 0;
        [ServiceValidation(ValidationRule.MaxLength, "2")]
        [XmlIgnore]
        public int? Build { get; set; }


        [XmlElement("build", IsNullable = false, Namespace = "")]
        public string SerializableBuild
        {
            get { return this.Build == null ? string.Empty : this.Build.ToString(); }
            set { this.Build = int.Parse(value); }
        }

        
    }
}
