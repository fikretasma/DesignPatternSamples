using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.SampleTwo.Adapters
{
    class ExternalSystemOneAdapter : IExternalSystemAdapter
    {
        private ExternalSystemOne ExternalSystemOne { get; set; }

        public ExternalSystemOneAdapter()
        {
            this.ExternalSystemOne = new ExternalSystemOne();
        }

        public void Close()
        {
            ExternalSystemOne.End();
        }

        public void Open()
        {
            ExternalSystemOne.Start();
        }
    }
}
