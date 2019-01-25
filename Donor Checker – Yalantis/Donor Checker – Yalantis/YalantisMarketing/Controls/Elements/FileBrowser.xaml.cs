using Microsoft.Win32;
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
    /// Логика взаимодействия для FileBrowser.xaml
    /// </summary>
    public partial class FileBrowser : UserControl
    {
        public FileBrowser()
        {
            InitializeComponent();
        }

        private void Browse_click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Cursor Files|*.csv";
            fd.Title = "Change .csv file";
            if (fd.ShowDialog() == true)
                File_path_textbox.Text = fd.FileName;            
        }

        public string File_patch
        {
            get { return File_path_textbox.Text; }
            set { File_path_textbox.Text = value; }
        }
    }
}
