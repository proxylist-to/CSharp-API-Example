using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace CSharp_ProxyList.to_API_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //API KEY FROM https://proxylist.to/dashboard/
            string API_KEY = "PROXY-xxxxxxxx-LIST-xxxxxxxx-TO";

            WebClient webClient = new WebClient();

            //HTTP PROXY LIST
            string http = webClient.DownloadString("https://api.proxylist.to/http?key=" + API_KEY);

            //SOCKS4 PROXY LIST
            string socks4 = webClient.DownloadString("https://api.proxylist.to/http?key=" + API_KEY);

            //SOCKS5 PROXY LIST
            string socks5 = webClient.DownloadString("https://api.proxylist.to/http?key=" + API_KEY);

            //FOR AN ARRAY, SPLIT BY NEWLINE
            string[] httpArray = http.Split(new string[] { "\n" }, StringSplitOptions.None);
        }
    }
}
