using System;
using System.ComponentModel;

namespace Portal.Model
{
    public class BaseModel : IDisposable, INotifyPropertyChanged
    {
        public BaseModel()
        {

        }
        public int id { get; set; }
        public bool deleted { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }


        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
