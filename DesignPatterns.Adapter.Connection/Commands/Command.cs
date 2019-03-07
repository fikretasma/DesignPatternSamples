using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.SampleOne
{
    public abstract class Command
    {
        private string commandText;
        public string CommandText
        {
            get { return commandText; }
            set { commandText = value; }
        }

        private Connection connection;
        public Connection Connection
        {
            get { return connection; }
            set { connection = value; }
        }

        public abstract T ExecuteScalar<T>();
    }
}
