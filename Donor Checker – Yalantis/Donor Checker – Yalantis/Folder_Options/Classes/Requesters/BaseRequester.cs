using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Folder_Options.Classes
{
   public class BaseRequester : Requester
    {
        public BaseRequester()
        {
            resultpath = "metrics_result_" + DateTime.Today.ToShortDateString() + ".csv";
        }
        public override ParsedResult Parse(string domain, string proxy = null)
        {
            return new ParsedResult() { Url = domain};
        }
    }
}
