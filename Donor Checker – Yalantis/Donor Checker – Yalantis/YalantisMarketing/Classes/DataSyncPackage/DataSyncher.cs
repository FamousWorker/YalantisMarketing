using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YalantisMarketing.Classes.CsvReadWrite;
using YalantisMarketing.Controls.Elements;

namespace YalantisMarketing.Classes.DataSyncPackage
{
    public class DataSyncher
    {
        ICsvReaderWriter _csvReaderWriter;
        ITextGetter _textGetter;
        public DataSyncher()
        {
            _csvReaderWriter = new SimpleCsvReaderWriter();
        }

        public bool SyncData(string savefile, string examplefile, IEnumerable<ColumnSelector> parameters)
        {
            List<string> result = new List<string>();
            List<string> savedstrings = _csvReaderWriter.ReadFile(savefile);
            List<string> examplestrings = _csvReaderWriter.ReadFile(examplefile);
            foreach (var saved in savedstrings)
            {
                string synchstring = saved;
                string twin = examplestrings.FirstOrDefault(s => s.Substring(0,s.IndexOf(';')).ToLower().Trim() == saved.ToLower().Trim());
                if(twin != null)
                {
                    string[] twinparams = twin.Split(';');
                    foreach (var par in parameters)
                    {
                        if (par.Index < twinparams.Length)
                            synchstring += ";" + twinparams[par.Index];
                    }                    
                }
                result.Add(synchstring);
            }
            return _csvReaderWriter.Write(savefile, new TextFromListGetter(result));
        }




    }
}
