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
        ProxyServer _webProxy;
        protected string _baseurl;
        protected AParseResultBuilder()
        {
            _webLoader = new SimpleWebLoader();
        }
        public void SetProxy()
        {
            _webProxy = ProxyServers.GetProxy();
        }
        public void RemoveProxy()
        {
            _webProxy = null;
            _webLoader.Proxy = null;
        }
        public void Exp()
        {
            if (_webProxy != null)
            {
                if (_webProxy.Limits == 100) _webProxy = ProxyServers.GetProxy();
                _webProxy.Proxy = _webProxy.Proxy;
            }
            _webProxy.Limits++;
        }
        protected string GetHTML(string domain)
        {
            string html;
            if (_webProxy != null)
            {
                if (_webProxy.Limits == 100) _webProxy = ProxyServers.GetProxy();
                if (_webProxy != null) _webLoader.Proxy = _webProxy.Proxy;
            }
            html = _webLoader.GetHTML(domain);
            if (html != null) _webProxy.Limits++;
            return html;
        }
        protected void SetUrl(string url)
        {
            _baseurl = url;
        }

        public abstract string BuildHeader();
        public abstract string Build(string domain);
    }
}
