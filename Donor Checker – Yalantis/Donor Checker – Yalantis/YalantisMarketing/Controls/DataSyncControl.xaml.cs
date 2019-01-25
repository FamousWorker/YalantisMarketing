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
using YalantisMarketing.Controls.Elements;

namespace YalantisMarketing.Controls
{
    /// <summary>
    /// Логика взаимодействия для DataSyncControl.xaml
    /// </summary>
    public partial class DataSyncControl : UserControl
    {
        List<ColumnSelector> _selectors;

        public DataSyncControl()
        {
            InitializeComponent();
            MainSelector_combobox.SelectedIndex = 0;
            _selectors = new List<ColumnSelector>();
            InitSelectors(6);
        }
  
        void InitSelectors(int selectorcount)
        {
            for (int i = 0; i < selectorcount; i++)
            {
                var cs = new ColumnSelector();
                _selectors.Add(cs);
                Selectors_panel.Children.Add(cs);
            }
        }

        private void MainSelector_combobox_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }
    }
}
