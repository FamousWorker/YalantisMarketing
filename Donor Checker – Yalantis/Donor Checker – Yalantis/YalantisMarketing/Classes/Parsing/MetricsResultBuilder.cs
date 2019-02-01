using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YalantisMarketing.Classes.Parsing
{
    public class MetricsResultBuilder : AParseResultBuilder
    {
        JsonWrap _jsonResult;
        public bool DA_PA { get; set; }
        public bool CF_TF { get; set; }
        public MetricsResultBuilder()
        {
            SetUrl("http://marketing.yalantis.com/seo.php?url=");
            DA_PA = false;
            CF_TF = false;
        }
        public override string Build(string domain)
        {
            string result = "";
            string json = GetHTML(domain);
            if (json != null)
            {
                _jsonResult = JsonConvert.DeserializeObject<JsonWrap>(json);                
            }
            if (CF_TF) result += ";" + _jsonResult.data.CF + ";" + _jsonResult.data.TF;
            if (DA_PA) result += ";" + _jsonResult.data.DA + ";" + _jsonResult.data.PA;
            return result;
        }

        public override string BuildHeader()
        {
            string result = "";
            if (CF_TF) result += ";CF;TF";
            if (DA_PA) result += ";DA;PA";
            return result;
        }
        
    }
    class JsonWrap { public JsonData data; }
    class JsonData
    {
        public string DA;
        public string PA;
        public string TF;
        public string CF;
    }
}
