using DHLDeWebService.Entities.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLDeWebService.Entities.Request.Concrete
{
    [Serializable]
    public class DHLGetVersionRequest
    {
        public DHLVersion Version { get; set; }
    }
}
