using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YalantisMarketing.Classes.CsvReadWrite
{
   public interface ICsvReaderWriter
    {
        List<string> ReadFile(string filepath);

        bool Write(string filepath, ITextGetter text);
    }
}
