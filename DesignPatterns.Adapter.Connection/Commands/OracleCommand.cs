using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.SampleOne
{
    public class OracleCommand : Command
    {
        public override T ExecuteScalar<T>()
        {
            return TypeConverter.ConvertToType<T>("Oracle Command");
        }
    }
}
