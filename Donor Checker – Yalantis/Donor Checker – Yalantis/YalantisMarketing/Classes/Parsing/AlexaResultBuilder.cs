using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace YalantisMarketing.Classes.Parsing
{
    public class AlexaResultBuilder : AParseResultBuilder
    {
        public AlexaResultBuilder()
        {
            SetUrl("https://www.alexa.com/siteinfo/");
        }
        public override string Build(string domain)
        {
            string result = domain;

            try
            {
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                string html = GetHTML(_baseurl + domain);
                if (html == null)
                {
                    result += ";-;;;;;;;;;;;;;;;;";
                }
                else
                {
                    doc.LoadHtml(html);

                    HtmlAgilityPack.HtmlNode node = doc.DocumentNode.SelectSingleNode("//span[@class=\'span8\']//h1[@class=\'h3\']");
                    if (node != null)
                        result = node.InnerText.Split(' ')[0].Trim();// Url
                    else
                        return result + ";-;;;;;;;;;;;;;;;;";

                    node = doc.DocumentNode.SelectSingleNode("//section[@id=\'rank-panel-content\']//span[@class=\'globleRank\']//strong[@class=\'metrics-data align-vmiddle\']");
                    string Rank = node.InnerText.Trim();
                    if (Rank != "-")
                        result += ";" + Rank; //rank
                    else return result + ";-;;;;;;;;;;;;;;;;";
                    

                    decimal firstvisitors = 0, addvisitors = 0;
                    node =
                        doc.DocumentNode.SelectSingleNode("//section[@id=\'keyword-content\']//strong[@class=\'metrics-data align-vmiddle\']");
                    string Organic_Search = "-";
                    string Overall_Visits = "-";
                    if (node != null)
                    {
                        Organic_Search = node.InnerText.Trim();
                        if (Organic_Search != "-")
                        {
                            string s = Organic_Search.Remove(node.InnerText.Trim().Length - 2);
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
                            Overall_Visits = (firstvisitors + addvisitors).ToString();
                            Overall_Visits.Remove(Overall_Visits.Length - 1);
                            Overall_Visits = Overall_Visits.Replace(',', '.');
                            Overall_Visits = Overall_Visits.TrimEnd('0').TrimEnd('.');
                            Overall_Visits += "K";
                        }
                    }
                    result += ";" + Overall_Visits; //Overall_Visits                    

                    HtmlAgilityPack.HtmlNodeCollection nc = doc.DocumentNode.SelectNodes("//section[@id=\'engagement-content\']//strong[@class=\'metrics-data align-vmiddle\']");
                    if (nc != null)
                    {
                        result += ";" + nc[2].InnerText.Trim();//Time_On_Site
                        result += ";" + nc[1].InnerText.Trim().Replace('.', ',');//Pages_per_Visit
                        result += ";" + nc[0].InnerText.Trim();//Bounce_Rate
                    }
                    else result += ";;;";

                    result += ";" + Organic_Search.Remove(Organic_Search.IndexOf('.'));  // Organic_Search

                    HtmlAgilityPack.HtmlNodeCollection htmlNodes =
                        doc.DocumentNode.SelectNodes("//table[@id=\'demographics_div_country_table\']/tbody//tr");
                    if (htmlNodes != null & htmlNodes.Count > 1)
                    {
                        //Countres
                        int i = 1;
                        foreach (HtmlAgilityPack.HtmlNode row in htmlNodes)
                        {
                            string country = row.SelectSingleNode("td[1]").InnerText.Split(';')[1].Trim();
                            string procent = row.SelectSingleNode("td[2]").InnerText.Trim();
                            result += ";" + country + ";" + procent;
                            i++;
                        }
                        while (i < 5) { i++; result += ";;"; }
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
            return ";World rank;Overall Visits;Time On Site;Pages per Visit;Bounce Rate;Organic Search;Country 1;%;Country 2;%;Country 3;%;Country 4;%;Country 5;%;";
        }
    }
}
