using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConvertionLibrary;

namespace ConfigLibrary
{
    public class ConfigHelper
    {
        public static T GetValue<T>(string parameterName)
        {
            ConfigBase configBase = ConfigFactory.GetManager();
            object configValue = configBase.GetParamValue(parameterName);
            return ConversionHelper.Convert<T>(configValue);
        }
    }
}
