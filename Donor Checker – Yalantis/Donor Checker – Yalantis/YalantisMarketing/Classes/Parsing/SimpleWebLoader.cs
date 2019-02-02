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
        public WebProxy Proxy { set { _proxy = value; } }
        WebProxy _proxy;
        public string GetHTML(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Headers.Add("User-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:62.0) Gecko/20100101 Firefox/62.0");
                if (_proxy != null)
                    webClient.Proxy = _proxy;
                return webClient.DownloadString(url );
            }
            catch (WebException ex)
            {
                //MessageBox.Show(ex.ToString());
                return null;
            }
        }
    }
}
