using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YalantisMarketing.Classes.OutreachPackage;

namespace YalantisMarketing.Classes.DataContexts
{
    public class OutReachDataContex
    {
        IReader _reader;
        public void SetWebReader()
        {
            _reader = new WebReader();
        }
        public void SetLocalReader()
        {
            _reader = new LocalReader();
        }

        public List<SearchResult> CheckDomainNames(string[] domains,string filepath)
        {
            if (_reader == null) return null;
            List<SearchResult> res = new List<SearchResult>();
            List<string> filedomains = _reader.Read(filepath);
            foreach (var dom in domains)
            {
                res.Add(new SearchResult() { Name = dom,
                    Found = (filedomains.Where(x => x.Contains(dom)).Count() > 0)
                    });
            }
            res.Sort((x,y) => -1 * x.Found.CompareTo(y.Found));
            return res;
        }

    }
}
