using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Folder_Options.Classes
{
    class AlexaRequester : Requester
    {
        public AlexaRequester()
        {
            url = "https://www.alexa.com/siteinfo/";
            resultpath = "alexa_result_"+ DateTime.Today.ToShortDateString()+ ".csv";
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
                    result.Rank = "-";
                    return result;
                }
                doc.LoadHtml(html);

                HtmlAgilityPack.HtmlNode node = doc.DocumentNode.SelectSingleNode("//span[@class=\'span8\']//h1[@class=\'h3\']");
                if (node != null)
                    result.Url = node.InnerText.Split(' ')[0].Trim();
                else
                {
                    result.Url = domain;
                    result.Rank = "-";
                    return result;
                }
                //span[@class='col-pad']//strong[@class='metrics-data align-vmiddle']
                node = doc.DocumentNode.SelectSingleNode("//section[@id=\'rank-panel-content\']//span[@class=\'globleRank\']//strong[@class=\'metrics-data align-vmiddle\']");
                if (node != null)
                    result.Rank = node.InnerText.Trim();

                if (result.Rank == "-")
                {
                    result.Url = domain;
                    result.Rank = "-";
                    return result;
                }

                HtmlAgilityPack.HtmlNodeCollection nc = doc.DocumentNode.SelectNodes("//section[@id=\'engagement-content\']//strong[@class=\'metrics-data align-vmiddle\']");
                if (nc != null)
                {
                    result.Bounce_Rate = nc[0].InnerText.Trim();
                    result.Pages_per_Visit = nc[1].InnerText.Trim();
                    result.Pages_per_Visit = result.Pages_per_Visit.Replace('.', ',');
                    result.Time_On_Site = nc[2].InnerText.Trim();
                }


                decimal firstvisitors = 0, addvisitors = 0;
                node =
                    doc.DocumentNode.SelectSingleNode("//section[@id=\'keyword-content\']//strong[@class=\'metrics-data align-vmiddle\']");
                if (node != null)
                {
                    result.Organic_Search = node.InnerText.Trim();
                    if (result.Organic_Search != "-")
                    {
                        string s = result.Organic_Search.Remove(node.InnerText.Trim().Length - 2);
                        s = s.Replace('.', ',');
                        try
                        {
                            firstvisitors = Convert.ToDecimal(s);
                        }
                        catch (Exception)
                        {
                            firstvisitors = 0;
                        }
                        node =
                        doc.DocumentNode.SelectSingleNode("//section[@id=\'keyword-content\']//span[@class=\'align-vmiddle change-wrapper change-down color-gen2 \']");
                        if (node == null)
                            node =
                           doc.DocumentNode.SelectSingleNode("//section[@id=\'keyword-content\']//span[@class=\'align-vmiddle change-wrapper change-up \']");
                        if (node != null)
                        {
                            s = node.InnerText.Trim().Remove(node.InnerText.Trim().Length - 2);
                            s = s.Replace('.', ',');
                            try { addvisitors = Convert.ToDecimal(s); }
                            catch (Exception)
                            {
                                addvisitors = 0;
                            }
                        }
                        result.Overall_Visits = (firstvisitors + addvisitors).ToString();
                        result.Overall_Visits.Remove(result.Overall_Visits.Length - 1);
                        result.Overall_Visits = result.Overall_Visits.Replace(',', '.');
                        result.Overall_Visits = result.Overall_Visits.TrimEnd('0').TrimEnd('.');
                        result.Overall_Visits += "K";
                    }
                    else result.Overall_Visits = "-";
                    if (result.Organic_Search.Contains('.')) result.Organic_Search = result.Organic_Search.Remove(result.Organic_Search.IndexOf('.'));
                }


                //table[@id='demographics_div_country_table']/tbody//tr/td[2]
                HtmlAgilityPack.HtmlNodeCollection htmlNodes =
                    doc.DocumentNode.SelectNodes("//table[@id=\'demographics_div_country_table\']/tbody//tr");
                if (htmlNodes != null & htmlNodes.Count > 1)
                {
                    foreach (HtmlAgilityPack.HtmlNode row in htmlNodes)
                    {
                        string country = row.SelectSingleNode("td[1]").InnerText.Split(';')[1].Trim();
                        string procent = row.SelectSingleNode("td[2]").InnerText.Trim();
                        result.CountresAdd(country, procent);
                    }
                }
                result.CountraseRelease();
                return result;
            }
            catch (Exception) { return new ParsedResult { Url = domain, Rank = "-" }; }
        }
    }
}
