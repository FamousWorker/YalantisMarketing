using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YalantisMarketing.Classes.DataSyncPackage;

namespace Tests
{
   public class LinkCutterTest
    {
        LinkCutter _lk;
        public LinkCutterTest()
        {
            _lk = new LinkCutter();
        }
        public void Tests(string testedfile)
        {
            _lk.Cut(testedfile);
        }
    }
}
