using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using YalantisMarketing.Classes.CsvReadWrite;
using YalantisMarketing.Classes.DataContexts;
using YalantisMarketing.Classes.OutreachPackage;
using YalantisMarketing.Windows;

namespace YalantisMarketing.Controls
{
    /// <summary>
    /// Логика взаимодействия для OutreachControl.xaml
    /// </summary>
    public partial class OutreachControl : UserControl
    {
        private OutReachDataContex _datacontex;
        public OutreachControl()
        {
            InitializeComponent();
            _datacontex = new OutReachDataContex();
            Load_local_combobox.SelectedIndex = 0;
            File_Browser.File_patch = "http://marketing.yalantis.com/backlinks.csv";
        }

        private void Load_local_combobox_dropdrownclosed(object sender, EventArgs e)
        {
            switch (Load_local_combobox.SelectedIndex)
            {
                case 0:
                    File_Browser.File_patch = "http://marketing.yalantis.com/backlinks.csv";
                    _datacontex.SetWebReader();
                    break;
                case 1:
                    File_Browser.File_patch = "";
                    _datacontex.SetLocalReader();
                    break;
                default:
                    break;
            }
        }

        public void CheckDomains()
        {
            if (File_Browser.File_patch == string.Empty) { MessageBox.Show("Введите имя файла!"); return; }
            string[] separator = { "\n", "\r" };
            string[] domains = Domains_textbox.Text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            if (domains.Count() == 0) { MessageBox.Show("Введите хотя бы 1 домен!"); return; }
            SearchResultWindow srw = new SearchResultWindow(_datacontex.CheckDomainNames(domains, File_Browser.File_patch));
            srw.Show();
        }
    }
}
