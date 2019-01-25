using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Xceed.Wpf.Toolkit;

namespace YalantisMarketing.Controls.Elements
{
    /// <summary>
    /// Логика взаимодействия для Counter.xaml
    /// </summary>
    public partial class Counter : UserControl
    {
        public Counter()
        {
            InitializeComponent();
        }
        [DisplayName("CounterText")]
        [CategoryAttribute("category")]
        [Description("Desc")]
        public string CounterText
        {
            get { return Counter_content_label.Content.ToString(); }
            set { Counter_content_label.Content = value; }
        }
        [DisplayName("CounterValue")]
        [CategoryAttribute("category")]
        [Description("Desc")]
        public int CounterValue
        {
            get
            {
                int res;
                int.TryParse(Counter_value_textbox.Text, out res);
                return res;
            }
            set { Counter_value_textbox.Text = value.ToString(); }
        }
        

        private void ButtonSpinner_Spin(object sender, Xceed.Wpf.Toolkit.SpinEventArgs e)
        {
            int count = int.Parse(Counter_value_textbox.Text);
            if (e.Direction == SpinDirection.Increase) count += 1;
            else if (count != 1) count -= 1;
            Counter_value_textbox.Text = count.ToString();
        }             

        private void Counter_value_textbox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (Char.IsDigit(e.Text, 0))
                return;
            e.Handled = true;
        }
    }
}
