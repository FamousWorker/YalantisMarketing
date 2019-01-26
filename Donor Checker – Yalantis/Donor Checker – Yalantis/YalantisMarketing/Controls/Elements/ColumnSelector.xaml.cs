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

namespace YalantisMarketing.Controls.Elements
{
    /// <summary>
    /// Логика взаимодействия для ColumnSelector.xaml
    /// </summary>
    public partial class ColumnSelector : UserControl
    {
        public ColumnSelector()
        {
            InitializeComponent();
            Selector_combobox.SelectedIndex = 0;
        }
        public int Index
        {
            set
            {
                Selector_combobox.SelectedIndex = value;
            }        
            get
            {
                return Selector_combobox.SelectedIndex;
            }
        }

        private void Selector_combobox_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }
    }
}
