using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Builders
{
    public class BuilderFactory
    {
        public Screen Build()
        {
            BuilderBase builder;
            string platform = ConfigurationManager.AppSettings["platform"];
            switch (platform) {
                case "web":
                    builder = new WebBuilder();
                    break;
                case "windows":
                    builder = new WinBuilder();
                    break;
                default:
                    throw new Exception("not implemented builder type");
                    break;
            }

            return builder.Build();
        }
    }
}
