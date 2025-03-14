using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_Await_ConsoleApp
{
    public class AwaitOperator
    {
        public static async Task Start()
        {
            Task<int> downloading = DownloadDocsMainPageAsync();
            Console.WriteLine($"{nameof(Start)}: Launched Downloading.");

            int bytesLoaded = await downloading;
            Console.WriteLine($"{nameof(Start)}: Downloaded {bytesLoaded} bytes.");

            ConsoleUi.DashLine();
            Console.WriteLine("Press any key to exit.");
        }

        private static async Task<int> DownloadDocsMainPageAsync()
        {
            Console.WriteLine($"{nameof(DownloadDocsMainPageAsync)}: About to start downloading.");

            var client = new HttpClient();
            byte[] content = await client.GetByteArrayAsync("https://learn.microsoft.com/en-us/");

            Console.WriteLine($"{nameof(DownloadDocsMainPageAsync)}: Finished Downloading.");
            return content.Length;
        }
    }
}
