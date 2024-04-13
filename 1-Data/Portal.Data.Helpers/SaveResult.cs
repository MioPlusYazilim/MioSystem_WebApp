using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Data.Heplers
{
    public class SaveResult : IDisposable
    {
        public bool isSuccess { get; set; }
        public object returnValue { get; set; }
        public string errorMessage { get; set; } = string.Empty;

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
