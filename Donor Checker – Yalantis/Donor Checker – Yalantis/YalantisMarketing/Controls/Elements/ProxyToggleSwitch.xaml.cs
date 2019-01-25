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
    /// Логика взаимодействия для ProxyToggleSwitch.xaml
    /// </summary>
    public partial class ProxyToggleSwitch : UserControl
    {
        public ProxyToggleSwitch()
        {
            InitializeComponent();
            Proxy_switcher_combobox.SelectedIndex = 0;
        }

        public bool isProxy
        {
            get
            {
                if (Proxy_switcher_combobox.SelectedIndex == 0) return false;
                else return true;                 
            }
        }

        private void Proxy_switcher_combobox_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }
    }
}
