using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace LineCounter
{
    internal class Snippets
    {
        public static void Run()
        {
            string url = null;
            var webClient = new WebClient();
            var fileStream = webClient.OpenRead(url);
            var reader = new StreamReader(fileStream);
        }
    }
}
