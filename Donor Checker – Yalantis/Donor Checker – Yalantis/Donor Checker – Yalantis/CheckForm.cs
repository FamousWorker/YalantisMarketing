using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Folder_Options
{
    public partial class CheckForm : Form
    {
        public CheckForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Cursor Files|*.csv";
            openFileDialog1.Title = "Change domains list in .csv format";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
                FilePath_textBox.Text = openFileDialog1.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] separator = { "\n", "\r" };
            string[] domains = Domains_textbox.Text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            if (domains.Count() == 0) { MessageBox.Show("Введите хотя бы 1 домен!"); return; }
            SearchResult se = new SearchResult(FilePath_textBox.Text, domains);
            if(!se.IsDisposed) se.Show();
        }

        private void Domains_textbox_TextChanged(object sender, EventArgs e)
        {
            Domains_textbox.Text = Domains_textbox.Text;
        }

        private void FilePath_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
