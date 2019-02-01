using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YalantisMarketing.Classes
{
    public delegate void UpdateProgressPanel(); //обновление прогресспанели
    public delegate void StartProgressPanel(int filescount, int streamscount, int timeout); // инициализация прогресспанели    
}
