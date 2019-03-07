using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.SampleOne
{
    public class SqlCommand : Command
    {
        public override T ExecuteScalar<T>()
        {
            return TypeConverter.ConvertToType<T>("Sql Command");
        }
    }
}
