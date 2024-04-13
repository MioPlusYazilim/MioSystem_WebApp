using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portal.Helpers
{
    public class ObjectConvert : IDisposable
    {
       
        public object[] ToArray(object args)
        {
            object[] MyData = null;
            string[] Mystr = ((string)args).Split('|');
            string[] Tstr = null;
            object[] tmp = new object[Mystr.Length - 1];
            for (int i = 0; i < tmp.Length; i++)
            {
                Tstr = Mystr[i].Split(';');
                tmp[i] = new CustomDataObject(Tstr[0], Tstr[1]);
            }

            return MyData = tmp;
        }
        public int ToInt32(object[] args, string Name)
        {
            if (args == null) return 0;
            int index = Array.FindIndex(args, w => ((CustomDataObject)w).Name == Name);
            if (index < 0 || ((CustomDataObject)args[index]).Value == null || ((CustomDataObject)args[index]).Value == DBNull.Value)
                return 0;
            else
                return index >= 0 ? Convert.ToInt32(((CustomDataObject)args[index]).Value) : 0;
        }
        public string ToString(object[] args, string Name)
        {
            if (args == null) return string.Empty;
            int index = Array.FindIndex(args, w => ((CustomDataObject)w).Name == Name);
            return index >= 0 ? Convert.ToString(((CustomDataObject)args[index]).Value) : string.Empty;

        }
        public bool ToBoolean(object[] args, string Name)
        {
            if (args == null) return false;
            int index = Array.FindIndex(args, w => ((CustomDataObject)w).Name == Name);
            return index >= 0 ? Convert.ToBoolean(((CustomDataObject)args[index]).Value) : false;
        }
        public DateTime ToDateTime(object[] args, string Name)
        {
            if (args == null) return DateTime.Now;
            int index = Array.FindIndex(args, w => ((CustomDataObject)w).Name == Name);
            return index >= 0 ? Convert.ToDateTime(((CustomDataObject)args[index]).Value) : DateTime.Now;
        }
        public object ToObject(object[] args)
        {
            object MyData = null;
            string Myval = string.Empty;
            for (int i = 0; args.Length > i; i++)
            {
                Myval = Myval + ((CustomDataObject)args[i]).Name + ";" + Convert.ToString(((CustomDataObject)args[i]).Value) + "|";
            }
            return MyData = Myval;
        }
        public object ToObject(object[] args, string Name)
        {
            if (args == null) return null;
            int index = Array.FindIndex(args, w => ((CustomDataObject)w).Name == Name);
            return index >= 0 ? ((CustomDataObject)args[index]).Value : null;
        }
        public object ObjectGetData(object[] args, string Name)
        {
            if (args == null) return null;
            int index = Array.FindIndex(args, w => ((CustomDataObject)w).Name == Name);
            return index >= 0 ? ((CustomDataObject)args[index]).Value : null;
        }
        public void SetData(object[] args, string Name, object Data)
        {
            if (args == null) return;
            for (int i = 0; args.Length > i; i++)
                if (((CustomDataObject)args[i]).Name == Name)
                {
                    ((CustomDataObject)args[i]).Value = Data;
                    break;
                }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
