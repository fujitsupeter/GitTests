using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {

            Logging.Logger.Log("Hello There!");
            Downloader.DownloaderClass d = new Downloader.DownloaderClass();

            string ds = string.Empty;

            Task<string> t = d.Download("http://www.liteolika.se");

            t.Wait();

            ds = t.Result;
            

            Console.ReadLine();

        }
    }
}
