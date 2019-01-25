using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.IO;

namespace csv_tool
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtBox1.Text) || String.IsNullOrEmpty(txtBox2.Text))
            {
                MessageBox.Show("Укажите csv файлы!");
                return;
            }

            Dictionary<string, string> dict = new Dictionary<string, string>();
            foreach (string s in File.ReadAllLines(txtBox2.Text))
            {
                string[] mass = s.Split(new[] { ';' }, 2);
                if (mass.Length != 2) continue;
                string key = mass[0].ToLower();
                if (!dict.ContainsKey(key)) dict.Add(key, mass[1]);
            }

            List<string> result = new List<string>();
            foreach (string s in File.ReadAllLines(txtBox1.Text))
            {
                string[] mass = s.Split(new[] { ';' }, 2);
                string key = mass[0].ToLower();
                if (dict.ContainsKey(key)) result.Add(mass[0] + ";" + dict[key]);
                else result.Add(s);
            }
            File.WriteAllLines(txtBox1.Text, result.ToArray());
            MessageBox.Show("Готово!");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "csv file (*.csv)|*.csv";
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();

            if (openFileDialog.ShowDialog() == true)
                txtBox1.Text = openFileDialog.FileName;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "csv file (*.csv)|*.csv";
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();

            if (openFileDialog.ShowDialog() == true)
                txtBox2.Text = openFileDialog.FileName;
        }
    }
}
