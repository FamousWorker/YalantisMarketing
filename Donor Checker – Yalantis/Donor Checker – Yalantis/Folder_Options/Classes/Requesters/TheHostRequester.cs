using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Folder_Options.Classes
{
    public class TheHostRequester : Requester
    {
        public TheHostRequester()
        {
            base.url = "https://thehost.ua/domains/whois/";
            resultpath = "thehost_result_" + DateTime.Today.ToShortDateString() + ".csv";
        }

        public override ParsedResult Parse(string domain, string proxy = null)
        {
            try
            {
                ParsedResult result = new ParsedResult();
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                string html = getHTML(domain, proxy);
                if (html == null)
                {
                    result.Url = domain;
                    result.expiridate = "-";
                    result.creationdate = "-";
                    return result;
                }
                doc.LoadHtml(html);
                HtmlAgilityPack.HtmlNode node = doc.DocumentNode.SelectSingleNode("//span[@class=\'span8\']//h1[@class=\'h3\']");
                if (node != null)
                {
                    result.Url = node.InnerText.Split(' ')[0].Trim();
                }                    
                else
                {
                    result.Url = domain;
                    result.expiridate = "-";
                    result.creationdate = "-";
                    return result;
                }


                return new ParsedResult();
            }
            catch (Exception) { return new ParsedResult { Url = domain, creationdate = "-", expiridate = "-" }; }
        }
    }
}
