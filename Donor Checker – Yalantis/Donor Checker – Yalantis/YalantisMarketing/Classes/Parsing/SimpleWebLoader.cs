using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace YalantisMarketing.Classes.Parsing
{
    class SimpleWebLoader : IWebLoader
    {
        public string GetHTML(string url, WebProxy proxy)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Headers.Add("User-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:62.0) Gecko/20100101 Firefox/62.0");
                if (proxy != null) webClient.Proxy = proxy;
                return webClient.DownloadString(url );
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
    }
}
