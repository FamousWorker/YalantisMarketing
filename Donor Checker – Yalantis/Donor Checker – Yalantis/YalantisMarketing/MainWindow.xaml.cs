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

namespace YalantisMarketing
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            HideButtons();
            Outreach_panel.Visibility = Visibility.Visible;
        }
        void HideButtons()
        {
            Outreach_panel.Visibility = Visibility.Collapsed;
            Data_sync_panel.Visibility = Visibility.Collapsed;
            Rank_parser_panel.Visibility = Visibility.Collapsed;
            Whois_panel.Visibility = Visibility.Collapsed;
            Lan_panel.Visibility = Visibility.Collapsed;
        }
        private void Main_TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TabControl mtc = sender as TabControl;
            HideButtons();
            switch (mtc.SelectedIndex)  
            {
                case 0:
                    Outreach_panel.Visibility = Visibility.Visible;
                    break;
                case 1:
                    Data_sync_panel.Visibility = Visibility.Visible;
                    break;
                case 2:
                    Rank_parser_panel.Visibility = Visibility.Visible;
                    break;
                case 3:
                    Whois_panel.Visibility = Visibility.Visible;
                    break;
                case 4:
                    Lan_panel.Visibility = Visibility.Visible;
                    break;
              
            }
        }

        private void Check_button_Click(object sender, RoutedEventArgs e)
        {
            Outreach_tab_control.CheckDomains();
        }

        private void Cut_off_button_Click(object sender, RoutedEventArgs e)
        {
            DataSync_tab_control.CutLinks();
        }

        private void Sync_button_Click(object sender, RoutedEventArgs e)
        {
            DataSync_tab_control.SyncData();
        }
    }
}
