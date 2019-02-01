using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YalantisMarketing.Classes
{
    public delegate void UpdateProgressPanel(string time, int files);
    public delegate void StartProgressPanel(int filescount, string time);
    public delegate string ParseDelegate(string domain);
    public delegate void WritedDelegate(List<string> writedlist);
}
