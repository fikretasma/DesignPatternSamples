using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.FtpAdapter
{
    class SftpAdapter : IFtpAdapter
    {
        public void Connect()
        {
            Console.WriteLine("Create Sftp Connection");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnect sftp");
        }

        public void DownloadFile()
        {
            Console.WriteLine("Download file from sftp");
        }

        public void UploadFile()
        {
            Console.WriteLine("Upload File to sftp");
        }
    }
}
