using Pars_tool.Class;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Pars_tool
{
    public partial class Form1 : Form
    {
        Requester requester;
        List<Thread> threads = new List<Thread>();
        public Form1()
        {
            InitializeComponent();
            SimilarWeb_radioButton.Checked = true;
        }

        string getLeftTime()
        {
            int siteleft = parsing_progressBar.Maximum - parsing_progressBar.Value;
            int timeleft = (siteleft * (int)Time_Out_numericUpDown.Value) / (int)Streams_numericUpDown.Value;
            int minleft = timeleft / 60;
            return  minleft.ToString() + " min";
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            switch (ParseButton.Text)
            {
                case "Parse":
                    CsvReaderWriter crw = new CsvReaderWriter(FilePath_textBox.Text, requester.GetResultPath());
                    parsing_progressBar.Value = 0;
                    parsing_progressBar.Maximum = crw.getMax();
                    for (int i = 0; i < Streams_numericUpDown.Value; i++)
                    {
                        Thread t = new Thread(delegate ()
                        {
                            while (true)
                            {
                                string source;

                                lock (crw) { source = crw.getNextSource(); }

                                if (source == null) { MessageBox.Show("Done!"); break; }
                                ParsedResult parsedResult = requester.Parse(source);
                                Progress_Label.Invoke(new Action(() =>
                                {
                                    parsing_progressBar.Value++;
                                    Progress_Label.Text = parsing_progressBar.Value.ToString() + "/" + parsing_progressBar.Maximum.ToString();
                                    TimeLeft_label.Text = getLeftTime();
                                }));

                                lock (crw) { crw.insertParsed(parsedResult); }

                                Thread.Sleep((int)Time_Out_numericUpDown.Value * 1000);
                            }

                        });
                        t.Start();
                        threads.Add(t);
                    }
                    break;
                case "Pause":
                    foreach (var item in threads)
                    {
                        if (item.IsAlive) item.
                    }
                    break;
                case "Continue":

                    break;
                default:
                    break;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Cursor Files|*.csv";
            openFileDialog1.Title = "Change domains list in .csv format";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                FilePath_textBox.Text = openFileDialog1.FileName;
        }


        #region GUI settings
        private void Proxy_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Proxy_comboBox.SelectedIndex)
            {
                case 0:
                        ProxyHost_textbox.Enabled = false;
                        ProxyHost_textbox.Text = "";
                        ProxyPort_textbox.Enabled = false;
                        ProxyPort_textbox.Text = "";
                    break;
                case 1:
                    ProxyHost_textbox.Enabled = true;
                    ProxyPort_textbox.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void SimilarWeb_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked) requester = new SpyMetricsRequester();
        }
                
        private void PorttextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else e.Handled = true;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var item in threads)
            {
                if (item.IsAlive) item.Abort();
            }
        }

        private void Alexa_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked) requester = new AlexaRequester();
        }

        #endregion

      
    }
}
