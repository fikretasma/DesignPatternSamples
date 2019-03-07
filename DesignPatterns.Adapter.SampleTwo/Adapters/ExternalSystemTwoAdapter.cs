using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.SampleTwo.Adapters
{
    class ExternalSystemTwoAdapter : IExternalSystemAdapter
    {
        private ExternalSystemTwo ExternalSystemTwo { get; set; }

        public ExternalSystemTwoAdapter()
        {
            this.ExternalSystemTwo = new ExternalSystemTwo();
        }

        public void Close()
        {
            ExternalSystemTwo.Terminate();
        }

        public void Open()
        {
            ExternalSystemTwo.Begin();
        }
    }
}
