using DesignPatterns.Bridge.DocumentBadSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.DocumentGoodSolution
{
    public class LogFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return String.Format("key : {0} value : {1} logged",key, value);
        }
    }
}
