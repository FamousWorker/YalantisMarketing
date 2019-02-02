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
using YalantisMarketing.Classes.DataContexts;

namespace YalantisMarketing.Controls
{
    /// <summary>
    /// Логика взаимодействия для WhoisControl.xaml
    /// </summary>
    public partial class WhoisControl : UserControl
    {
        WhoisDataContext _whoisDataContext; 
        public WhoisControl()
        {
            InitializeComponent();
            _whoisDataContext = new WhoisDataContext();
            SetEvents();
        }
        void SetEvents()
        {
            _whoisDataContext.StartParsing += Progress_panel.Init;
            _whoisDataContext.IsParsed += Progress_panel.Update;
            _whoisDataContext.ParsingEnd += Progress_panel.End;
            Proxy_switcher.ProxySwitched += new Action<bool>(x =>
            {
                if (x) _whoisDataContext.SetProxy();
                else _whoisDataContext.RemoveProxy();
            });
        }
        public void Pause()
        {
            _whoisDataContext.Pause();
        }
        public void Continue() => _whoisDataContext.Continue();
        public void Cancel()
        {
            _whoisDataContext.Cancel(MessageBox.Show("Сохранить результат?", "", MessageBoxButton.YesNo)
                == MessageBoxResult.Yes);
        }
        public bool Startparsing(Action act)
        {
            if (File_browser.File_patch == string.Empty) { MessageBox.Show("Введите имя файла!"); return false; }
            //if (Metrics_radio_button.IsChecked == true && Cf_Tf_checkbox.IsChecked == false && Da_Pa_checkbox.IsChecked == false)
            //{ MessageBox.Show("Выберите хотя бы одну метрику!"); return false; }
            Classes.WhoisPackage.WhoisParameters parserParams = new Classes.WhoisPackage.WhoisParameters();
            parserParams.CreationDate = (bool)Creation_data_checkbox.IsChecked;
            parserParams.ExpiryDate = (bool)Expiry_data_checkbox.IsChecked;
            parserParams.DomainAge = (bool)Domain_age_checkbox.IsChecked;
            parserParams.ServerName1 = (bool)Server_name_1_checkbox.IsChecked;
            parserParams.ServerName2 = (bool)Server_name_2_checkbox.IsChecked;
            parserParams.TimeOut = Time_out_counter.CounterValue;
            parserParams.ThreadCount = Thread_counter.CounterValue;
            parserParams.FilePath = File_browser.File_patch;
            _whoisDataContext.ParsingEnd += act;
            _whoisDataContext.Parse(parserParams);
            return true;
        }
    }
}
