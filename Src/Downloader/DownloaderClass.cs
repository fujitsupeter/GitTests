using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Downloader
{
    public class DownloaderClass
    {
        public async Task<string> Download(string url)
        {

            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(url);

            var content = await client.GetStringAsync(url);

            return content;

        }
    }
}
