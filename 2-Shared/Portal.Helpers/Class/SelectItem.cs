using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Helpers
{
    public class SelectItem : IDisposable
    {
        public int value { get; set; } = 0;
        public string code { get; set; }=string.Empty;
        public string name { get; set; }= string.Empty;
        public string text { get; set; } = string.Empty;
        public string modulIDs { get; set; } = string.Empty;
        public List<int> modulList { get { return (modulIDs ?? "0").Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList(); } }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
