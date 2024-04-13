using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Helpers
{
    public class CustomDataObject : IDisposable
    {
        private string _Name;
        private object _Value;

        public CustomDataObject(string name, object data)
        {
            _Name = name;
            _Value = data;
        }
        public object Value
        {
            get { return _Value; }
            set { _Value = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
