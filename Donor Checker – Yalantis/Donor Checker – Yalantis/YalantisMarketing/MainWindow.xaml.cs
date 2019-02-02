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
            ProxyServers.ServersInit();
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


        private void Sync_button_Click(object sender, RoutedEventArgs e)
        {
            DataSync_tab_control.SyncData();
        }

        private void Rank_Start_button_Click(object sender, RoutedEventArgs e)
        {
            if(RankParser_tab_control.Startparsing(new Action(SetEndRankParse)))
            {
                Rank_Cancel_button.IsEnabled = true;
                Rank_Start_button.Visibility = Visibility.Collapsed;
                Rank_Pause_button.Visibility = Visibility.Visible;
            }
        }
           
        void SetEndRankParse()
        {
            Rank_Pause_button.Visibility = Visibility.Collapsed;
            Rank_Continue_button.Visibility = Visibility.Collapsed;
            Rank_Start_button.Visibility = Visibility.Visible;
            Rank_Cancel_button.IsEnabled = false;
            ProxyServers.WriteServers();
        }
        private void Rank_Pause_button_Click(object sender, RoutedEventArgs e)
        {
            RankParser_tab_control.Pause();
            Rank_Continue_button.Visibility = Visibility.Visible;
            Rank_Pause_button.Visibility = Visibility.Collapsed;
        }

        private void Rank_Continue_button_Click(object sender, RoutedEventArgs e)
        {
            RankParser_tab_control.Continue();
            Rank_Pause_button.Visibility = Visibility.Visible;
            Rank_Continue_button.Visibility = Visibility.Collapsed;
        }

        private void Rank_Cancel_button_Click(object sender, RoutedEventArgs e)
        {
            RankParser_tab_control.Cancel();
            Rank_Pause_button.Visibility = Visibility.Collapsed;
            Rank_Continue_button.Visibility = Visibility.Collapsed;
            Rank_Start_button.Visibility = Visibility.Visible ;
            Rank_Cancel_button.IsEnabled = false;
        }

        private void Save_button_Click(object sender, RoutedEventArgs e)
        {
            Lan_tab_control.SaveProxys();
        }

        private void Delete_button_Click(object sender, RoutedEventArgs e)
        {
            Lan_tab_control.DeleteProxy();
        }

        private void Whois_Pause_button_Click(object sender, RoutedEventArgs e)
        {
            Whois_tab_control.Pause();
            Whois_Continue_button.Visibility = Visibility.Visible;
            Whois_Pause_button.Visibility = Visibility.Collapsed;
        }

        private void Whois_Continue_button_Click(object sender, RoutedEventArgs e)
        {
            Whois_tab_control.Continue();
            Whois_Pause_button.Visibility = Visibility.Visible;
            Whois_Continue_button.Visibility = Visibility.Collapsed;
        }

        private void Whois_Start_button_Click(object sender, RoutedEventArgs e)
        {
            if (Whois_tab_control.Startparsing(new Action(SetEndWhoisParse)))
            {
                Whois_Cancel_button.IsEnabled = true;
                Whois_Start_button.Visibility = Visibility.Collapsed;
                Whois_Pause_button.Visibility = Visibility.Visible;
            }
        }
        void SetEndWhoisParse()
        {
            Whois_Pause_button.Visibility = Visibility.Collapsed;
            Whois_Continue_button.Visibility = Visibility.Collapsed;
            Whois_Start_button.Visibility = Visibility.Visible;
            Whois_Cancel_button.IsEnabled = false;
            ProxyServers.WriteServers();
        }

        private void Whois_Cancel_button_Click(object sender, RoutedEventArgs e)
        {
            Whois_tab_control.Cancel();
            Whois_Pause_button.Visibility = Visibility.Collapsed;
            Whois_Continue_button.Visibility = Visibility.Collapsed;
            Whois_Start_button.Visibility = Visibility.Visible;
            Whois_Cancel_button.IsEnabled = false;
        }
    }
}
