﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Folder_Options.Classes
{
    public class SpyMetricsRequester : Requester
    {
        public SpyMetricsRequester()
        {
            url = "https://spymetrics.ru/en/website/";
            resultpath = "sm_result_" + DateTime.Today.ToShortDateString() + ".csv";
        }

        public override ParsedResult Parse(string domain, string proxy = null)
        {
            try
            { 
            ParsedResult result = new ParsedResult();
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            string html = getHTML(domain, proxy);

            if(html == null)
            {
                result.Url = domain;
                result.Rank = "-";
                return result;
            }
            doc.LoadHtml(html);

              HtmlAgilityPack.HtmlNode node = doc.DocumentNode.SelectSingleNode("//h1[@class=\"domain text-center-xs text-left-not-xs\"]");
            if (node != null)
                result.Url = node.InnerText.Trim().ToLower();
            else
            {
                result.Url = domain;
                result.Rank = "-";
                return result;
            }
             node = doc.DocumentNode.SelectSingleNode("//div[@id=\"worldRanking-item\"]//div[@class=\"rankValue\"]");
            if (node != null)
            {
                var rg = new Regex(@"#(.*?)<");
                result.Rank = rg.Match(node.InnerHtml.TrimEnd()).Groups[1].Value;
            }            

            HtmlAgilityPack.HtmlNodeCollection nc = doc.DocumentNode.SelectNodes("//td[@class=\"text-right\"]");
            if(nc != null)
            {
                result.Overall_Visits = nc[0].InnerText;
                result.Time_On_Site = nc[1].InnerText;
                result.Pages_per_Visit = nc[2].InnerText;
                result.Pages_per_Visit = result.Pages_per_Visit.Replace('.', ',');
                result.Bounce_Rate = nc[3].InnerText;
            }
            
            node = doc.DocumentNode.SelectSingleNode("//div[@id=\"review\"]");
            if(node != null)
            {
                var rg = new Regex("\"Organic Search\" [(](.*?)%");
                result.Organic_Search = rg.Match(node.InnerText).Groups[1].Value.TrimEnd();
                    if (result.Organic_Search.Contains('.')) result.Organic_Search = result.Organic_Search.Remove(result.Organic_Search.IndexOf('.'));
            }
            
            HtmlAgilityPack.HtmlNodeCollection htmlNodes =
                doc.DocumentNode.SelectNodes("//table[@id=\"countriesBreakdownTable\"]//tr");
            if (htmlNodes != null)
            {
                foreach (HtmlAgilityPack.HtmlNode row in htmlNodes)
                {
                    string country = row.SelectSingleNode("td").InnerText;
                    string procent = row.SelectSingleNode("td/div[@class=\"shareValue\"]").InnerText;
                    result.CountresAdd(country, procent);
                }
            }            
            result.CountraseRelease();
            return result;
            }
            catch (Exception ex)  { MessageBox.Show(ex.ToString()); return new ParsedResult { Url = domain, Rank = "-" }; }
        }       

    }
}
