using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigLibrary
{
    internal abstract class ConfigBase
    {
        private SortedList values;

        private SortedList Values {
            get {
                if (values == null)
                {
                    values = new SortedList();
                }

                return values;
            }
        }

        protected abstract object GetValue(string parameterName);

        internal object GetParamValue(string parameterName)
        {
            //if value exists in cache return from cache
            if (Values.ContainsKey(parameterName))
            {
                return values[parameterName];
            }
            Values.Add(parameterName, GetValue(parameterName));
            return Values[parameterName];
        }
    }
}
