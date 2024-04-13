using System;

namespace Portal.Data.Entities
{
    public class BaseEntity : IDisposable
    {
        public BaseEntity()
        {
        }

        public int ID { get; set; }
        public bool Deleted { get; set; }


        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
