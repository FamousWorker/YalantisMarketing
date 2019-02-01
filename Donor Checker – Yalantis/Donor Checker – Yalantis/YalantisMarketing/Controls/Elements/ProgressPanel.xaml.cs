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
        public void Init(int maxcount, int streamscount, int timeout)
        {
            _progressPanelDataContex.Init(maxcount, streamscount, timeout);
        }
        public void Update()
        {
            _progressPanelDataContex.CurrentValue++;
        }
        public void End()
        {
            _progressPanelDataContex.CurrentValue = _progressPanelDataContex.MaxValue;
        }
    }
}
