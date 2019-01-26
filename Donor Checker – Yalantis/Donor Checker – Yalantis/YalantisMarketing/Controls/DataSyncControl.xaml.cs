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
using YalantisMarketing.Controls.Elements;

namespace YalantisMarketing.Controls
{
    /// <summary>
    /// Логика взаимодействия для DataSyncControl.xaml
    /// </summary>
    public partial class DataSyncControl : UserControl
    {
        List<ColumnSelector> _selectors;
        DataSyncDataContext _dataSyncDataContext;
        public DataSyncControl()
        {
            InitializeComponent();
            _selectors = new List<ColumnSelector>();
            InitSelectors(7);
            _dataSyncDataContext = new DataSyncDataContext();
        }
  
        void InitSelectors(int selectorcount)
        {
            for (int i = 0; i < selectorcount; i++)
            {
                var cs = new ColumnSelector();
                _selectors.Add(cs);
                Selectors_panel.Children.Add(cs);
            }
            _selectors[0].Index = 1;
        }

        private void MainSelector_combobox_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }
        public void SyncData()
        {
            if (Save_filebrowser.File_patch == string.Empty || Example_filebrowser.File_patch == string.Empty) { MessageBox.Show("Выберите файлы для синхронизации!"); return; }
            if (_dataSyncDataContext.SyncData(Save_filebrowser.File_patch, Example_filebrowser.File_patch, _selectors.Where(s => s.Index != 0)))
                MessageBox.Show("Done!");
        }

        public void CutLinks()
        {
            if (Cutter_filebrowser.File_patch == string.Empty) { MessageBox.Show("Введите имя файла!"); return; }
            if (_dataSyncDataContext.CutLinks(Cutter_filebrowser.File_patch))
                MessageBox.Show("Done!");
        }
    }
}
