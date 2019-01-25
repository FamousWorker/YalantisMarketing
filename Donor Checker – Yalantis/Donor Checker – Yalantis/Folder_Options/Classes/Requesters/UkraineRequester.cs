using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Folder_Options.Classes
{
    class UkraineRequester : Requester
    {
        public UkraineRequester()
        {
            base.url = "https://www.ukraine.com.ua/domains/whois-service/?domain=";
            resultpath = "ukraine_result_" + DateTime.Today.ToShortDateString() + ".csv";
        }
        public override ParsedResult Parse(string domain, string proxy = null)
        {
            try
            {
                ParsedResult result = new ParsedResult();
                result.Url = domain;
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                string html = getHTML(domain, proxy);
                if (html == null)
                {
                    result.Url = domain;
                    result.expiridate = "not found";
                    result.creationdate = "";
                    return result;
                }
                doc.LoadHtml(html);
                HtmlAgilityPack.HtmlNode node = doc.DocumentNode.SelectSingleNode("//div[@class=\'whois-response\']");
                if (node != null)
                {
                    var rg1 = new Regex(@"Registrar Registration Expiration Date: (.*?)T");
                    result.expiridate = rg1.Match(node.InnerHtml).Groups[1].Value;
                    if (result.expiridate == string.Empty)
                    {
                        result.expiridate = "not found";
                        result.creationdate = "";
                        return result;
                    }
                    var rg2 = new Regex(@"Creation Date: (.*?)T");
                    result.creationdate = rg2.Match(node.InnerHtml).Groups[1].Value;
                }
                else
                {
                    result.Url = domain;
                    result.expiridate = "not found";
                    result.creationdate = "";
                    return result;
                }
                return result;
            }
            catch (Exception) { return new ParsedResult { Url = domain, creationdate = "", expiridate = "not found" }; }
        }
    }
}
