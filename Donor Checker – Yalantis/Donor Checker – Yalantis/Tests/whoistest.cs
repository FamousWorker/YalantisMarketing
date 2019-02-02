using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tests
{
    public class whoistest
    {
        HtmlAgilityPack.HtmlDocument doc;
        public whoistest()
        {
            doc = new HtmlAgilityPack.HtmlDocument(); ;
            doc.LoadHtml(File.ReadAllText(@"pages/Yalantis.html"));

        }
        public void CreationDate()
        {
            string result = "";
            HtmlAgilityPack.HtmlNode node = doc.DocumentNode.SelectSingleNode("//h1[@class=\"domain text-center-xs text-left-not-xs\"]");

            if (node != null)
                result = node.InnerText.Trim().ToLower(); //url
            else
                result += ";-;;;;;;;;;;;;;;;;;";

            node = doc.DocumentNode.SelectSingleNode("//div[@id=\"worldRanking-item\"]//div[@class=\"rankValue\"]");
            if (node != null)
            {
                var rg = new Regex(@"#(.*?)<");
                result += ";" + rg.Match(node.InnerHtml.TrimEnd()).Groups[1].Value; //rank
            }
            else result += ";";
            node = doc.DocumentNode.SelectSingleNode("//div[@id=\"categoryRanking-item\"]//div[@class=\"rankValue\"]");
            if (node != null)
            {
                var rg = new Regex(@"#(.*?)<");
                result += ";" + rg.Match(node.InnerHtml.TrimEnd()).Groups[1].Value; // category rank
            }
            else result += ";";

            HtmlAgilityPack.HtmlNodeCollection nc = doc.DocumentNode.SelectNodes("//td[@class=\"text-right\"]");
            if (nc != null)
            {
                result += ";" + nc[0].InnerText; //Overall_Visits
                result += ";" + nc[1].InnerText;//Time_On_Site
                result += ";" + nc[2].InnerText.Replace('.', ',');//Pages_per_Visit
                result += ";" + nc[3].InnerText;//Bounce_Rate
            }
            else result += ";;;;";

            node = doc.DocumentNode.SelectSingleNode("//div[@id=\"review\"]");
            if (node != null)
            {
                var rg = new Regex("\"Organic Search\" [(](.*?)%");
                string Organic_Search = rg.Match(node.InnerText).Groups[1].Value.TrimEnd();
                Organic_Search.Remove(Organic_Search.IndexOf('.'));
                result += ";" + Organic_Search; //Organic_Search
            }
            else result += ";";

            HtmlAgilityPack.HtmlNodeCollection htmlNodes =
           doc.DocumentNode.SelectNodes("//table[@id=\"countriesBreakdownTable\"]//tr");
            if (htmlNodes != null)
            {
                //Countres
                for (int i = 0; i < 5; i++)
                {
                    if (htmlNodes.Count > i)
                        result += ";" + htmlNodes[i].SelectSingleNode("td").InnerText + ";" + htmlNodes[i].SelectSingleNode("td/div[@class=\"shareValue\"]").InnerText;
                    else result += ";;";
                }
            }
            else result += ";;;;;;;;;;;";
            Console.WriteLine(result);
        }

    }
}
