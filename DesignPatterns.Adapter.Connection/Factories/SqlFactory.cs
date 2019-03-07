using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.SampleOne
{
    class SqlFactory : DBFactory
    {
        public override Connection CreateConnection()
        {
            return new SqlConnection();
        }

        public override Command CreateCommand()
        {
            return new SqlCommand();
        }

        public override DataAdapter CreateDataAdapter()
        {
            return new SqlDataAdapter();
        }
    }
}
