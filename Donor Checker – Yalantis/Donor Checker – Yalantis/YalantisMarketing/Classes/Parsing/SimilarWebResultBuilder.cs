using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace YalantisMarketing.Classes.Parsing
{
    public class SimilarWebResultBuilder : AParseResultBuilder
    {
        public SimilarWebResultBuilder()
        {
            base.SetUrl("https://spymetrics.ru/en/website/");
        }

        public override string Build(string domain)
        {
            string result = domain;
            try
            {
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                string html = GetHTML(domain);
                if (html == null)
                {
                    result += ";-;;;;;;;;;;;;;;;;";
                }
                else
                {
                    doc.LoadHtml(html);
                    HtmlAgilityPack.HtmlNode node = doc.DocumentNode.SelectSingleNode("//h1[@class=\"domain text-center-xs text-left-not-xs\"]");

                    if (node != null)
                        result = node.InnerText.Trim().ToLower(); //url
                    else
                        return result + ";-;;;;;;;;;;;;;;;;";

                    node = doc.DocumentNode.SelectSingleNode("//div[@id=\"worldRanking-item\"]//div[@class=\"rankValue\"]");
                    if (node != null)
                    {
                        var rg = new Regex(@"#(.*?)<");
                        result += ";" + rg.Match(node.InnerHtml.TrimEnd()).Groups[1].Value; //rank
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
                    else result += ";;;;;;;;;;";
                }
                return result;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                return domain + ";-;;;;;;;;;;;;;;;;";
            }
        }

        public override string BuildHeader()
        {
            return
                ";World rank;Overall Visits;Time On Site;Pages per Visit;Bounce Rate;Organic Search;Country 1;%;Country 2;%;Country 3;%;Country 4;%;Country 5;%;";
        }
    }
}
