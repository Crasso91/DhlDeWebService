using DHLDeWebService.Entities.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLDeWebService.Entities.Request.Abstract
{
    public interface IDHLRequest
    {
        DHLHeader Header { get; set; }
    }
}
