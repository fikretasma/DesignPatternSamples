using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class TypeConverter
    {
        public static T ConvertToType<T>(object o)
        {
            try
            {
                return (T)Convert.ChangeType(o, typeof(T));
            }
            catch
            {
                throw new Exception("Couldn't be converted");
            }
        }
    }
}
