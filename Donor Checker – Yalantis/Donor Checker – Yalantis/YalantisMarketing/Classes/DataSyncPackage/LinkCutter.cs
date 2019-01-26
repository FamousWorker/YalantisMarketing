using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YalantisMarketing.Classes.CsvReadWrite;

namespace YalantisMarketing.Classes.DataSyncPackage
{
    public class LinkCutter
    {
        ICsvReaderWriter _csvReaderWriter;
        ITextGetter _text;
        string _fileresult;
        public LinkCutter()
        {
            _csvReaderWriter = new SimpleCsvReaderWriter();
            _fileresult = "cutter_result.csv";
        }
        public bool Cut(string filepath)
        {
            _text = new TextFromListGetter(CutLinks(GetLinks(filepath)));
            return _csvReaderWriter.Write(_fileresult, _text);
        }
        private List<string> GetLinks(string filepath)
        {
            return _csvReaderWriter.ReadFile(filepath);
        }
        private List<string> CutLinks(List<string> links)
        {
            List<string> result = new List<string>();
            foreach (var item in links)
            {
                if (item == string.Empty) continue;
                string addetstring = item;
                if (addetstring.Substring(0, 8) == "https://")
                {
                    addetstring = addetstring.Remove(0, 8);
                }
                if (addetstring.Substring(0, 7) == "http://")
                {
                    addetstring = addetstring.Remove(0, 7);
                }
                if (addetstring.Substring(0, 4) == "www.")
                {
                    addetstring = addetstring.Remove(0, 4);
                }
                if (addetstring.Contains(@"/"))
                    addetstring = addetstring.Remove(addetstring.IndexOf('/'));
                result.Add(addetstring);
            }
            return result;
        }
    }
}
