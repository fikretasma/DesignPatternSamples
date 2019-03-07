using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.SampleOne
{
    class OracleFactory : DBFactory
    {
        public override Connection CreateConnection()
        {
            return new OracleConnection();
        }

        public override Command CreateCommand()
        {
            return new OracleCommand();
        }

        public override DataAdapter CreateDataAdapter()
        {
            return new OracleDataAdapter();
        }
    }
}
