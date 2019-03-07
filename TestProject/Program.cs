using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            if (ConfigurationManager.AppSettings["retryCount"] == null)
            {
                throw new Exception("retryCount parameter is null");
            }
            
            int retryCount;
            if (!Int32.TryParse(ConfigurationManager.AppSettings["retryCount"], out retryCount))
            {
                throw new Exception("RetryCount conversion exception");
            }

            if (ConfigurationManager.AppSettings["timeout"] == null)
            {

                throw new Exception("timeout poaramter is null");
            }

            int timeout;
            if (Int32.TryParse(ConfigurationManager.AppSettings["timeout"], out timeout))
            {
                throw new Exception("Timeout conversion exception");
            }

            Console.WriteLine($"retryCount : {retryCount}, timeout : {timeout}");
            Console.ReadLine();
            
            // Bu uygulamada ne sorun var?
             //**** UYGULAMANIN MEVCUTTA YAPTIKLARI NELER?
            //1-) Configten değer okuyor
                //Yarın başka bir yerden bu Değeri okumak istesem burası değişir mi?
                //Örneğin retryCount u bir jsonConfig dosyasından okusam bu kod değişir mi?
            //2-)Convertion yapıyor
            //3-)Hata yönetimini yapıyor

            //Configten aynı uygulamada bir başka değişken okumak istersem ne olur
             // Duplicate kod oluştu
             // kod sayısı artıyor.
             // bağımlılığa bağlı kod sayısı artmaya başladı
        }
    }
}
