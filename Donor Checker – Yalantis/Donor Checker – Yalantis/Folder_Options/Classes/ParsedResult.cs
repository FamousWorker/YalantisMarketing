using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Folder_Options.Classes
{
    public class ParsedResult
    {
        public static ParsedResult getHeaders()
        {
            return new ParsedResult()
            {
                Url = "Url",
                rank = "World rank",
                Overall_Visits = "Overall Visits",
                time_on_site = "Time On Site",
                pages_per_visit = "Pages per Visit",
                Time_On_Site = "Time On Site",
                Bounce_Rate = "Bounce Rate",
                Organic_Search = "Organic Search",
                country_1 = "Country 1",
                country_1_procent = "%",
                country_2 = "Country 2",
                country_2_procent = "%",
                country_3 = "Country 3",
                country_3_procent = "%",
                country_4 = "Country 4",
                country_4_procent = "%",
                country_5 = "Country 5",
                country_5_procent = "%",
                DA = "DA",
                PA = "PA",
                TF = "TF",
                CF = "CF",
                ExpiriDate = "Expiry Date",
                CreatinDate = "Creation Date"
            };
        }
        List<string[]> countres = new List<string[]>();

        public void CountresAdd(string country, string procent)
        {
            countres.Add(new string[] { country, procent});
        }
        public void CountraseRelease()
        {
            if (countres.Count >= 1)
            {
                country_1 = countres[0][0];
                country_1_procent = countres[0][1];
            }
            if (countres.Count >= 2)
            {
                country_2 = countres[1][0];
                country_2_procent = countres[1][1];
            }
            if (countres.Count >= 3)
            {
                country_3 = countres[2][0];
                country_3_procent = countres[2][1];
            }
            if (countres.Count >= 4)
            {
                country_4 = countres[3][0];
                country_4_procent = countres[3][1];
            }
            if (countres.Count == 5)
            {
                country_5 = countres[4][0];
                country_5_procent = countres[4][1];
            }
        }

        string url;
        public string Url
        {
            get { return url; }
            set { url = value; }
        }
        string rank;
        public string Rank
        {
            get { return rank; }
            set { rank = value; }
        }
        string overall_visits;
        public string Overall_Visits
        {
            get { return overall_visits; }
            set { overall_visits = value; }
        }
        string time_on_site;
        public string Time_On_Site
        {
            get { return time_on_site; }
            set { time_on_site = value; }
        }
        string pages_per_visit;
        public string Pages_per_Visit
        {
            get { return pages_per_visit; }
            set { pages_per_visit = value; }
        }
        string bounce_rate;
        public string Bounce_Rate
        {
            get { return bounce_rate; }
            set { bounce_rate = value; }
        }
        string prganic_search;
        public string Organic_Search
        {
            get { return prganic_search; }
            set { prganic_search = value; }
        }
        string country_1;
        public string Country_1
        {
            get { return country_1; }
            set { country_1 = value; }
        }
        string country_1_procent;
        public string Country_1_Procent
        {
            get { return country_1_procent; }
            set { country_1_procent = value; }
        }
        string country_2;
        public string Country_2
        {
            get { return country_2; }
            set { country_2 = value; }
        }
        string country_2_procent;
        public string Country_2_Procent
        {
            get { return country_2_procent; }
            set { country_2_procent = value; }
        }
        string country_3;
        public string Country_3
        {
            get { return country_3; }
            set { country_3 = value; }
        }
        string country_3_procent;
        public string Country_3_Procent
        {
            get { return country_3_procent; }
            set { country_3_procent = value; }
        }
        string country_4;
        public string Country_4
        {
            get { return country_4; }
            set { country_4 = value; }
        }
        string country_4_procent;
        public string Country_4_Procent
        {
            get { return country_4_procent; }
            set { country_4_procent = value; }
        }
        string country_5;
        public string Country_5
        {
            get { return country_5; }
            set { country_5 = value; }
        }
        string country_5_procent;
        public string Country_5_Procent
        {
            get { return country_5_procent; }
            set { country_5_procent = value; }
        }
        string DA;
        public string da
        {
            get { return DA; }
            set { DA = value; }
        }
        string PA;
        public string pa
        {
            get { return PA; }
            set { PA = value; }
        }
        string TF;
        public string tf
        {
            get { return TF; }
            set { TF = value; }
        }
        string CF;
        public string cf
        {
            get { return CF; }
            set { CF = value; }
        }
        string ExpiriDate;
        public string expiridate
        {
            get { return ExpiriDate; }
            set { ExpiriDate = value; }
        }
        string CreatinDate;
        public string creationdate
        {
            get { return CreatinDate; }
            set { CreatinDate = value; }
        }
        public JsonData data;
        public void SetJSONvalues()
        {
            if (data != null)
            {
                DA = data.DA;
                PA = data.PA;
                TF = data.TF;
                CF = data.CF;
            }
        }
    }

    public class JsonData
    {
        public string DA;
        public string PA;
        public string TF;
        public string CF;
    }
}
