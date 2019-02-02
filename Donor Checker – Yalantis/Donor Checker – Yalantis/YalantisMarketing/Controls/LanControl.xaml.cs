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
using YalantisMarketing.Classes.Parsing;

namespace YalantisMarketing.Controls
{
    /// <summary>
    /// Логика взаимодействия для LanControl.xaml
    /// </summary>
    public partial class LanControl : UserControl
    {
        public LanControl()
        {
            InitializeComponent();
           
            Proxys_datagrid.ItemsSource = ProxyServers.Servers;
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ProxyServers.AddProxy(Convert.ToInt32(Port_textbox.Text), Adress_textbox.Text,
                User_textbox.Text, Password_textbox.Text, Convert.ToInt32(Limits_textbox.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void Clear_Button_Click(object sender, RoutedEventArgs e)
        {
            ProxyServers.Clear();
            Proxys_datagrid.ItemsSource = ProxyServers.Servers;
        }
        public void DeleteProxy()
        {
            ProxyServer ps = Proxys_datagrid.SelectedItem as ProxyServer;
            if (ps != null)
                ProxyServers.Delete(ps);
        }
        public void SaveProxys()
        {
            if (ProxyServers.WriteServers())
                MessageBox.Show("Changes saved.");
        }
    }
}
