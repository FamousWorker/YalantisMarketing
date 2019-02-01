using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace YalantisMarketing.Classes.Parsing
{
    public abstract class AParseResultBuilder
    {
        IWebLoader _webLoader;
        WebProxy _webProxy;
        string _baseurl;
        protected AParseResultBuilder()
        {
            _webLoader = new SimpleWebLoader();
        }
        public void SetProxy(WebProxy webProxy)
        {
            _webProxy = webProxy;
        }
        protected string GetHTML(string domain)
        {
            return _webLoader.GetHTML(_baseurl + domain, _webProxy);
        }
        protected void SetUrl(string url)
        {
            _baseurl = url;
        }

        public abstract string BuildHeader();
        public abstract string Build(string domain);
    }
}
