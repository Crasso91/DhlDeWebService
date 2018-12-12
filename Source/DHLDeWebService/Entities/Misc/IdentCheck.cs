using DHLDeWebService.Attributes;
using System.ComponentModel;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace DHLDeWebService.Entities.Misc
{
    [System.Serializable]
    public class IdentCheck : DHLServiceBaseType
    {
        [Required, ValidateObject]
        public Ident Ident { get; set; }

        
    }
}