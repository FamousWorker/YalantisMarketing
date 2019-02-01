using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace YalantisMarketing.Classes.Parsing
{
   public  class WhoisResulBuilder : AParseResultBuilder 
    {
        public bool CreationData { get; set; }
        public bool ExpiryData { get; set; }
        public bool DomainAge { get; set; }
        public bool ServerName1 { get; set; }
        public bool ServerName2 { get; set; }
        public WhoisResulBuilder()
        {
            base.SetUrl("https://dnsstuff.hostpro.ua/index.php?fWhois=");
        }
        public override string Build(string domain)
        {
            try
            {
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                string html = GetHTML(_baseurl + domain + "&tool=whois");
                if (html == null)
                {
                    throw new WebException();
                }
                else
                {
                    doc.LoadHtml(html);
                    string result = domain;
                        HtmlAgilityPack.HtmlNodeCollection htmlNodes =
                      doc.DocumentNode.SelectNodes("//tr[@class=\'secondRow\']");
                        if (htmlNodes != null & htmlNodes.Count > 1)
                        {
                            foreach (HtmlAgilityPack.HtmlNode row in htmlNodes)
                            {
                            if (CreationData)
                                if (row.SelectSingleNode("td[1]").InnerText.ToLower().Trim() == "creation data".Trim())
                                {
                                    string date = row.SelectSingleNode("td[2]").InnerText.Trim();
                                    result += ";" + date.Substring(0, date.IndexOf('T'));
                                }
                            if (ServerName1)
                                if (row.SelectSingleNode("td[1]").InnerText.ToLower().Trim() == "name server".Trim())
                                {
                                    string date = row.SelectSingleNode("td[2]").InnerText.Trim();
                                    result += ";" + date;
                                    ServerName1 = false;
                                    continue;
                                }
                            if (ServerName2)
                                if (row.SelectSingleNode("td[1]").InnerText.ToLower().Trim() == "name server".Trim())
                                {
                                    string date = row.SelectSingleNode("td[2]").InnerText.Trim();
                                    result += ";" + date;
                                    ServerName2 = false;
                                    continue;
                                }

                        }
                        }
                    if (ExpiryData)
                    {
                        htmlNodes =
                      doc.DocumentNode.SelectNodes("//tr[@class=\'firstRow\']");
                        if (htmlNodes != null & htmlNodes.Count > 1)
                        {
                            foreach (HtmlAgilityPack.HtmlNode row in htmlNodes)
                            {
                                if (row.SelectSingleNode("td[1]").InnerText.ToLower().Trim() == "Registrar Registration Expiration Date".ToLower().Trim())
                                {
                                    string date = row.SelectSingleNode("td[2]").InnerText.Trim();
                                    result += ";" + date.Substring(0, date.IndexOf('T'));
                                }
                            }
                        }
                    }
                    if(DomainAge)
                    {
                        result += "age";
                    }
                    return result;
                }
            }
            catch (Exception)
            {
                string result = domain;
                if (CreationData) result += ";";
                if (ExpiryData) result += ";";
                if (DomainAge) result += ";";
                if (ServerName1) result += ";";
                if (ServerName2) result += ";";
                return result;
            }
        }

        public override string BuildHeader()
        {
            string result = "";
            if (CreationData) result += ";Creation Date";
            if (ExpiryData) result += ";Expiry Date";
            if (DomainAge) result += ";Domain age";
            if (ServerName1) result += ";Server name #1";
            if (ServerName2) result += ";Server name #2";
            return result;
        }
    }
}
