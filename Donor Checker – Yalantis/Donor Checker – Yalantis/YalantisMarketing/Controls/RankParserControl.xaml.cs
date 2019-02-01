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
using YalantisMarketing.Classes.RankParserPackage;

namespace YalantisMarketing.Controls
{
    /// <summary>
    /// Логика взаимодействия для RankParserControl.xaml
    /// </summary>
    public partial class RankParserControl : UserControl
    {
        RankParserDataContex _rankParserDataContex;
        
        //RankParserParams _rankParserParams;
        public RankParserControl()
        {
            InitializeComponent();
            _rankParserDataContex = new RankParserDataContex();
            Metrics_radio_button.IsChecked = true;
            _rankParserDataContex.SetMetrics();
            SetEvents();
            //_rankParserParams = new RankParserParams();
            //this.DataContext = _rankParserParams;
        }
        void SetEvents()
        {
            _rankParserDataContex.StartParsing += Progress_panel.Init;
            _rankParserDataContex.IsParsed += Progress_panel.Update;
        }
        public void Pause()
        {
            _rankParserDataContex.Pause();
        }
        public void Continue() => _rankParserDataContex.Continue();
        public void Cancel()
        {
            bool save = MessageBox.Show("Сохранить результат?","",MessageBoxButton.YesNo) == MessageBoxResult.Yes;
            _rankParserDataContex.Cancel(save);
        }
        public void Startarsing(Action act)
        {
            if (File_browser.File_patch == string.Empty) { MessageBox.Show("Введите имя файла!"); return; }
            if(Metrics_radio_button.IsChecked == true && Cf_Tf_checkbox.IsChecked ==false && Da_Pa_checkbox.IsChecked == false)
            { MessageBox.Show("Выберите хотя бы одну метрику!"); return; }
            Classes.RankParserPackage.RankParserParams parserParams = new Classes.RankParserPackage.RankParserParams();
            parserParams.CF_TF = (bool)Cf_Tf_checkbox.IsChecked;
            parserParams.DA_PA = (bool)Da_Pa_checkbox.IsChecked;
            parserParams.TimeOut = Time_out_counter.CounterValue;
            parserParams.ThreadCount = Thread_counter.CounterValue;
            parserParams.FilePath = File_browser.File_patch;
            _rankParserDataContex.PasingEnd += act;
            _rankParserDataContex.Parse(parserParams);

        }

        private void Metrics_radio_button_click(object sender, RoutedEventArgs e)
        {
            _rankParserDataContex.SetMetrics();
        }

        private void SimilarWeb_radio_button_click(object sender, RoutedEventArgs e)
        {
            _rankParserDataContex.SetSimilar();
        }

        private void Alexa_radio_button_click(object sender, RoutedEventArgs e)
        {
            _rankParserDataContex.SetAlexa();
        }
    }
}
