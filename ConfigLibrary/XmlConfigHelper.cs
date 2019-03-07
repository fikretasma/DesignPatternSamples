using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigLibrary
{
    // dışardan bu dll dıiından erişilmesini istemiyorum
    internal class XmlConfigHelper : ConfigBase
    {
        protected override object GetValue(string parameterName)
        {
            return ConfigurationManager.AppSettings[parameterName];
        }
    }
}
