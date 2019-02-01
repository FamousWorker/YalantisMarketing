using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class whoistest
    {
        HtmlAgilityPack.HtmlDocument doc;
        public whoistest()
        {
            doc = new HtmlAgilityPack.HtmlDocument(); ;
            doc.LoadHtml(File.ReadAllText(@"pages/aaa/dns.html"));

        }
        public void CreationDate()
        {
            HtmlAgilityPack.HtmlNodeCollection htmlNodes =
                    doc.DocumentNode.SelectNodes("//tr[@class=\'secondRow\']");
            if (htmlNodes != null & htmlNodes.Count > 1)
            {
                foreach (HtmlAgilityPack.HtmlNode row in htmlNodes)
                {
                    string country = row.SelectSingleNode("td[1]").InnerText.Trim();

                    string procent = row.SelectSingleNode("td[2]").InnerText.Trim();
                    if (country.ToLower().Trim() == "Creation Date".ToLower().Trim())
                        Console.Write(country + "----" + procent.Substring(0,procent.IndexOf('T')) + Environment.NewLine);
                    //if (country.ToLower().Trim() == "Registrar Registration Expiration Date".ToLower().Trim())
                    //    Console.Write(country + "----" + procent+ Environment.NewLine);
                    //if (country.ToLower().Trim() == "Name Server".ToLower().Trim())
                    //Console.Write(country + "----" + procent + Environment.NewLine);
                }
            }
        }

    }
}
