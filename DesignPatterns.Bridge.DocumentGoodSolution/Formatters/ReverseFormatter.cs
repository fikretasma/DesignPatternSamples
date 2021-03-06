﻿using DesignPatterns.Bridge.DocumentBadSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.DocumentGoodSolution
{
    public class ReverseFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return String.Format("{0} : {1}", key, new String(value.Reverse().ToArray()));
        }
    }
}
