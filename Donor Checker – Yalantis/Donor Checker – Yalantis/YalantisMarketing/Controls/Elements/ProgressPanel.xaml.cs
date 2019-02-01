using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using YalantisMarketing.Classes;
using YalantisMarketing.Classes.DataContexts;

namespace YalantisMarketing.Controls.Elements
{
    /// <summary>
    /// Логика взаимодействия для ProgressPanel.xaml
    /// </summary>
    public partial class ProgressPanel : UserControl
    {
        public ProgressPanelDataContex _progressPanelDataContex;
        public ProgressPanel()
        {
            InitializeComponent();
            
            _progressPanelDataContex = new ProgressPanelDataContex();
            this.DataContext = _progressPanelDataContex;
        }
        public void Init(int maxvalue, string time)
        {
            _progressPanelDataContex.Files = "0/" + maxvalue.ToString();
            _progressPanelDataContex.CurrentValue = 0;
            _progressPanelDataContex.MaxValue = maxvalue;
            _progressPanelDataContex.Time = time;
        }
        public void Update(string time, int files)
        {
            _progressPanelDataContex.Files = (_progressPanelDataContex.MaxValue - files) + "/" + _progressPanelDataContex.MaxValue.ToString();
            _progressPanelDataContex.Time = time;
            _progressPanelDataContex.CurrentValue++;
        }
    }
}
