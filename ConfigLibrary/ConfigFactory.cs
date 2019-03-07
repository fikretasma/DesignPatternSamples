using ConvertionLibrary;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigLibrary
{
   internal class ConfigFactory
    {
        private static ConfigBase manager;
        public static ConfigBase GetManager()
        {
            if (manager != null)
                return manager;

            ConfigBase configbase = new XmlConfigHelper();
            string managerName = ConversionHelper.Convert<string>(configbase.GetParamValue("managerName"));

            switch (managerName)
            {
                case "XmlConfig":
                    manager = configbase;
                    break;
                case "JsonConfig":
                    manager = new JsonConfigHelper();
                    break;
                default:
                    throw new NotImplementedException("Config Manger name not defined");
            }

            return manager;
        }
    }
}
