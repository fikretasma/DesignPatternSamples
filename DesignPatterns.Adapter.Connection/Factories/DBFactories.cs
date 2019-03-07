using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.SampleOne.Factories
{
    public class DBFactories
    {
        public static DBFactory GetFactory()
        {
            // config ten okuyarak alınabilir.Demo amçlı har coded yazıldı
            return new SqlFactory();
        }


        private static DBFactory factory;
        //private static object lockObject = new object();

        //public static DBFactory GetFactoryFromCache()
        //{
        //    if (factory != null)
        //    {
        //        return factory;
        //    }

        //    lock (lockObject)
        //    {
        //        if (factory == null)
        //        {
        //            factory = GetFactory();
        //        }

        //        return factory;
        //    }
        //}

    }
}
