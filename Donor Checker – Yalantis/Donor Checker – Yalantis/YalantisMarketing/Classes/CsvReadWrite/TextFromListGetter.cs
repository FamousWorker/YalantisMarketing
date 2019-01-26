using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YalantisMarketing.Classes.CsvReadWrite
{
    public class TextFromListGetter : ITextGetter
    {
        List<string> _list;
        public TextFromListGetter(List<string> list)
        {
            _list = list;
        }
        public string GetWritedText()
        {
            string resultstring = "";
            if (_list != null)
                foreach (var item in _list)
                {
                    resultstring += Environment.NewLine + item;
                }
            return resultstring;
        }
    }
}
