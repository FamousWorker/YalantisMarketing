using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Pars_tool.Class
{
    public abstract class Requester
    {
        public string GetResultPath()
        {
            return resultpath;
        }
        protected string getHTML(string domain, string proxy)
        {
            try
            {
                WebClient webClient = new WebClient();
                if (proxy != null)
                {
                    WebProxy webProxy = new WebProxy(proxy);
                    webClient.Proxy = webProxy;
                    webClient.Proxy.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials;
                }
                return webClient.DownloadString(url + domain);
            }
            catch (WebException ex)
            {
                // MessageBox.Show(ex.ToString());
                return null;
            }
        }
        protected string url;
        protected string resultpath;
        public abstract ParsedResult Parse(string domain, string proxy = null);
    }
}
