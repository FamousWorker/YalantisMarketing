using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Folder_Options.Classes
{
    public abstract class Requester
    {
        
        public string GetResultPath()
        {
            return resultpath;
        }
        public void getDA_PA(string domain, ParsedResult pr)
        {
            WebClient webClient = new WebClient();            
            string json = webClient.DownloadString(apiurl + domain);
            if(json != null)
            {
                ParsedResult timer = JsonConvert.DeserializeObject<ParsedResult>(json);
                pr.data = timer.data;
            }
          
        }
        protected string getHTML(string domain, string proxy)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Headers.Add("User-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:62.0) Gecko/20100101 Firefox/62.0");
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
        string apiurl = "http://marketing.yalantis.com/seo.php?url=";

        public abstract ParsedResult Parse(string domain, string proxy = null);
    }
}
