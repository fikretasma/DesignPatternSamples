using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.SampleOne
{
    public abstract class DataAdapter
    {
        public abstract void Fill(DataTable table);
    }
}
