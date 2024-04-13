using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Model.Utils
{
    public class RequestType : IDisposable
    {
        public int typeID { get; set; }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
