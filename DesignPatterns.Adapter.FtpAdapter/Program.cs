using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.FtpAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IFtpAdapter ftpAdapter = new FtpAdapter();
            ftpAdapter.Connect();
            ftpAdapter.DownloadFile();
            ftpAdapter.Disconnect();

            IFtpAdapter sftpAdapter = new SftpAdapter();
            sftpAdapter.Connect();
            sftpAdapter.DownloadFile();
            sftpAdapter.Disconnect();
        }
    }
}
