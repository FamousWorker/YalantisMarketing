using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

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
                    string creationDate = "", expiryDate = "";
                    if (CreationData)
                    {
                        result += ";";
                        string s = "";
                        var node = doc.DocumentNode.SelectSingleNode(@"//tr[@class='secondRow' and td/b='Creation Date']/td[2]");
                        if (node != null) s = node.InnerText;
                        if (s != "")
                        {
                            result += s.Substring(0, s.IndexOf('T'));
                            creationDate =   s.Substring(0, s.IndexOf('T'));
                        }
                    }
                    if (ExpiryData)
                    {
                        result += ";";
                        string s = "";
                        var node = doc.DocumentNode.SelectSingleNode(@"//tr[@class='firstRow' and td/b='Registrar Registration Expiration Date']/td[2]");
                        if (node != null) s = node.InnerText;
                        if (s != "")
                        {
                            result += s.Substring(0, s.IndexOf('T'));
                            expiryDate = s.Substring(0, s.IndexOf('T'));
                        }
                    }
                    if (DomainAge)
                    {
                        result += ";";
                        if(expiryDate != String.Empty && creationDate != String.Empty)
                        {
                            string[] ed = expiryDate.Split('-');
                            string[] cd = creationDate.Split('-');
                            try
                            {
                                string age;
                                int expiryDays = Convert.ToInt32(ed[0]) * 365 + Convert.ToInt32(ed[1]) * 12 + Convert.ToInt32(ed[2]);
                                int creationDays = Convert.ToInt32(cd[0]) * 365 + Convert.ToInt32(cd[1]) * 12 + Convert.ToInt32(cd[2]);
                                int ageDays = expiryDays - creationDays;
                                int years, mounths, days;
                                years = ageDays / 365;
                                mounths = (ageDays % 365) / 12;
                                days = (ageDays % 365) % 12;
                                age = years.ToString() + "-" + mounths.ToString() + "-" + days.ToString();
                                result += age;
                            }
                            catch (Exception)
                            {

                            }
                        }
                    }

                    if (ServerName1)
                    {
                        result += ";";
                        string s = "";
                        var node = doc.DocumentNode.SelectSingleNode(@"//tr[@class='secondRow' and td/b='Name Server']/td[2]");
                        if (node != null) s = node.InnerText;
                        if (s != "") result += s;
                    }
                    if (ServerName2)
                    {
                        result += ";";
                        string s = "";
                        var node = doc.DocumentNode.SelectSingleNode(@"//tr[@class='firstRow' and td/b='Name Server']/td[2]");
                        if (node != null) s = node.InnerText;
                        if (s != "") result += s;
                    }

                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
