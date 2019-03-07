using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.FtpAdapter
{
    class FtpAdapter : IFtpAdapter
    {
        public void Connect()
        {
            Console.WriteLine("Create Ftp Connection");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnect ftp");
        }

        public void DownloadFile()
        {
            Console.WriteLine("Download file from ftp");
        }

        public void UploadFile()
        {
            Console.WriteLine("Upload File to ftp");
        }
    }
}
