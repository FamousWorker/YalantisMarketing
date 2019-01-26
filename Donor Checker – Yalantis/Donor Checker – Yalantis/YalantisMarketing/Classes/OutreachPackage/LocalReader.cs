using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YalantisMarketing.Classes.CsvReadWrite;

namespace YalantisMarketing.Classes.OutreachPackage
{
    public class LocalReader : IReader
    {
        ICsvReaderWriter _csvReaderWriter;

        public LocalReader()
        {
            _csvReaderWriter = new CsvReaderWriter();
        }
        public List<string> Read(string filepath)
        {
            return _csvReaderWriter.ReadFile(filepath);
        }
    }
}
