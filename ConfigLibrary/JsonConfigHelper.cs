using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigLibrary
{
    internal class JsonConfigHelper : ConfigBase
    {
        protected override object GetValue(string parameterName)
        {
            return 5;
        }
    }
}
