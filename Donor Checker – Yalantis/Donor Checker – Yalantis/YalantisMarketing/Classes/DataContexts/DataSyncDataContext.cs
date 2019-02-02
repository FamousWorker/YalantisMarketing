using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YalantisMarketing.Classes.DataSyncPackage;
using YalantisMarketing.Controls.Elements;

namespace YalantisMarketing.Classes.DataContexts
{
    public class DataSyncDataContext
    {
        DataSyncher _dataSyncher;

        public DataSyncDataContext()
        {
            _dataSyncher = new DataSyncher();
        }
        public bool SyncData(string savefile, string examplefile, IEnumerable<ColumnSelector> parameters)
        {
            return _dataSyncher.SyncData(savefile, examplefile, parameters);
        }
    }
}
