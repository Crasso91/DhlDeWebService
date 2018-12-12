using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace DHLDeWebService.Entities.Misc
{
    [Serializable]
    public class ShipmentItem 
    {
        [XmlElement(ElementName = "weightInKG")]
        public decimal WeightInKG { get; set; }
        [XmlIgnore]
        public int? LengthInCM { get; set; }
        [XmlIgnore]
        public int? WidthInCM { get; set; }
        [XmlIgnore]
        public int? HeightInCM { get; set; }

        [XmlElement("lengthInCM", IsNullable = false)]
        public string SerializableLengthInCM
        {
            get { return this.LengthInCM == null ? string.Empty : this.LengthInCM.ToString(); }
            set { this.LengthInCM = int.Parse(value); }
        }

        [XmlElement("widthInCM", IsNullable = false)]
        public string SerializableWidthInCM
        {
            get { return this.WidthInCM == null ? string.Empty : this.WidthInCM.ToString(); }
            set { this.WidthInCM = int.Parse(value); }
        }

        [XmlElement("heightInCM", IsNullable = false)]
        public string SerializableHeightInCM
        {
            get { return this.HeightInCM == null ? string.Empty : this.HeightInCM.ToString(); }
            set { this.HeightInCM = int.Parse(value); }
        }

        
    }
}