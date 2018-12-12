using DHLDeWebService.Entities.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLDeWebService.Entities.Response.Concrete
{
    [Serializable]
    public class DHLGetVersionResponse
    {
        public GetVersionResponse GetVersionResponse { get; set; }
    }

    [Serializable]
    public class GetVersionResponse
    {
        public DHLVersion Version { get; set; }
    }
}
