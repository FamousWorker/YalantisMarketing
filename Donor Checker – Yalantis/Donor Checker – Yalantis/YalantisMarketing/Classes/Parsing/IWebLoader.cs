using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace YalantisMarketing.Classes.Parsing
{
    public interface IWebLoader
    {
        string GetHTML(string url, WebProxy proxy);
    }
}
