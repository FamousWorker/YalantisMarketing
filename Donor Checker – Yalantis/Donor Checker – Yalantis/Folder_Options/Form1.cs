using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Folder_Options.Classes;
using System.Threading;
using System.Linq;

namespace Folder_Options
{
    public partial class Form1 : Form
    {
        Requester parserequester, whoisrequester;
        List<Thread> threads = new List<Thread>();
        bool isparsedtoken = false;
        bool iswhoistoken = false;
        bool isload = false;
        CsvReaderWriter crw,whoisreader;
        public Form1()
        {
            InitializeComponent();
            Source_comboBox.SelectedIndex = 1;
            parserequester = new SpyMetricsRequester();
            WhoisSource_comboBox.SelectedIndex = 1;
            whoisrequester = new UkraineRequester();
            Selector_1_comboBox.SelectedIndex = 1;
            Selector_2_comboBox.SelectedIndex = 0;
            Selector_3_comboBox.SelectedIndex = 0;
            Selector_4_comboBox.SelectedIndex = 0;
            Selector_5_comboBox.SelectedIndex = 0;
            Selector_6_comboBox.SelectedIndex = 0;
            load_local_combobox.SelectedIndex = 0;
        }
        private void ParseButton_Click(object sender, EventArgs e)
        {
            switch (ParseButton.Text)
            {
                case "Start":
                    bool write_headers = true;
                    if(Source_comboBox.SelectedIndex == 0 )
                    {
                        if ((!Da_pa_checkbox.Checked && !Cf_tf_checkbox.Checked))
                        {
                            MessageBox.Show("Выберете хоть одну метрику!");
                            return;
                        }
                        write_headers = false;
                    }
                    isparsedtoken = true;
                    crw = 
                        new CsvReaderWriter(ParseFilePath_textBox.Text, parserequester.GetResultPath(), Da_pa_checkbox.Checked, Cf_tf_checkbox.Checked,write_headers,false);
                    parsing_progressBar.Value = 0;
                    parsing_progressBar.Maximum = crw.getMax();
                    for (int i = 0; i < Streams_numericUpDown.Value; i++)
                    {
                        Thread t = new Thread(delegate ()
                        {
                            while (true)
                            {
                                if (isparsedtoken)
                                {
                                    string source;

                                    lock (crw) { source = crw.getNextSource(); }

                                    if (source == null)
                                    {
                                        CancelButton.Invoke(new Action(() =>
                                        {
                                            ParseButton.Text = "Start";
                                            isparsedtoken = false;
                                        }));
                                        break;
                                    }
                                    ParsedResult parsedResult = parserequester.Parse(source);
                                    if (Da_pa_checkbox.Checked || Cf_tf_checkbox.Checked)
                                        parserequester.getDA_PA(source, parsedResult);
                                    Progress_Label.Invoke(new Action(() =>
                                    {
                                        parsing_progressBar.Value++;
                                        Progress_Label.Text = parsing_progressBar.Value.ToString() + "/" + parsing_progressBar.Maximum.ToString();
                                        TimeLeft_label.Text = getLeftTime((int)Time_Out_numericUpDown.Value, (int)Streams_numericUpDown.Value);
                                    }));
                                    Thread.Sleep((int)Time_Out_numericUpDown.Value * 1000);
                                    lock (crw) { crw.insertParsed(parsedResult); }
                                }
                            }
                        });
                        t.Start();
                        threads.Add(t);
                    }
                    ParseButton.Text = "Pause";
                    CancelButton.Enabled = true;
                    break;
                case "Pause":
                    isparsedtoken = false;
                    ParseButton.Text = "Continue";
                    break;
                case "Continue":
                    isparsedtoken = true;
                    ParseButton.Text = "Pause";
                    break;
                default:
                    break;
            }
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Save parsed data?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                crw.endProcess();
            }
            isparsedtoken = true;
            CancelButton.Enabled = false;
        }
        private void sync_button_Click_1(object sender, EventArgs e)
        {
            CsvSynchronier csvSynchronier = new CsvSynchronier();
            csvSynchronier.StartSynch(SavePath_textBox.Text, Example_textBox.Text,
                Selector_1_comboBox.SelectedIndex, Selector_2_comboBox.SelectedIndex, Selector_3_comboBox.SelectedIndex,
                Selector_4_comboBox.SelectedIndex, Selector_5_comboBox.SelectedIndex, Selector_6_comboBox.SelectedIndex);
        }

        private void check_button_Click(object sender, EventArgs e)
        {
            string[] separator = { "\n", "\r" };
            string[] domains = Domains_textbox.Text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            if (domains.Count() == 0) { MessageBox.Show("Введите хотя бы 1 домен!"); return; }
             SearchResult se = new SearchResult(Check_Domains_list_textBox.Text, domains, isload);
            if (!se.IsDisposed) se.Show();
        }
        private void cut_button_Click_1(object sender, EventArgs e)
        {
            LinkCutter.CutLinks(Cutter_textbox.Text);
        }

        private void Whoisstart_button_Click_1(object sender, EventArgs e)
        {
            switch (WhoisStart_button.Text)
            {
                case "Start":
                    iswhoistoken = true;
                    whoisreader =
                        new CsvReaderWriter(Whois_textBox.Text, whoisrequester.GetResultPath(), false, false, false, true);
                    Whois_progressBar.Value = 0;
                    Whois_progressBar.Maximum = whoisreader.getMax();
                    for (int i = 0; i < WhoisStreams_numericUpDown.Value; i++)
                    {
                        Thread t = new Thread(delegate ()
                        {
                            while (true)
                            {
                                if (iswhoistoken)
                                {
                                    string source;

                                    lock (whoisreader) { source = whoisreader.getNextSource(); }

                                    if (source == null)
                                    {
                                        WhoisCancel_button.Invoke(new Action(() =>
                                        {
                                            WhoisStart_button.Text = "Start";
                                            iswhoistoken = false;
                                            WhoisCancel_button.Enabled = false;
                                        }));
                                        break;
                                    }
                                    ParsedResult parsedResult = whoisrequester.Parse(source);
                                    WhoisCountLeft_label.Invoke(new Action(() =>
                                    {
                                        Whois_progressBar.Value++;
                                        WhoisCountLeft_label.Text = Whois_progressBar.Value.ToString() + "/" + Whois_progressBar.Maximum.ToString();
                                        WhoisTimeLeft_label.Text = getWhoisLeftTime((int)Whois_TimeOut_numericUpDown.Value, (int)WhoisStreams_numericUpDown.Value);
                                    }));
                                    Thread.Sleep((int)Whois_TimeOut_numericUpDown.Value * 1000);
                                    lock (whoisreader) { whoisreader.insertParsed(parsedResult); }
                                }
                            }
                        });
                        t.Start();
                        threads.Add(t);
                    }
                    WhoisStart_button.Text = "Pause";
                    WhoisCancel_button.Enabled = true;
                    break;
                case "Pause":
                    iswhoistoken = false;
                    WhoisStart_button.Text = "Continue";
                    break;
                case "Continue":
                    iswhoistoken = true;
                    WhoisStart_button.Text = "Pause";
                    break;
                default:
                    break;
            }
        }

        private void WhoisCansel_button_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Save parsed data?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                whoisreader.endProcess();
            }
            iswhoistoken = true;
            WhoisCancel_button.Enabled = false;
        }

        #region FilePathSeth
        void SetFilePath(TextBox tb)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Cursor Files|*.csv";
            openFileDialog1.Title = "Change .csv file";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                tb.Text = openFileDialog1.FileName;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SetFilePath(SavePath_textBox);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            SetFilePath(Check_Domains_list_textBox);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SetFilePath(Example_textBox);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            SetFilePath(ParseFilePath_textBox);
        }
        private void cutterfilepath_Click(object sender, EventArgs e)
        {
            SetFilePath(Cutter_textbox);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SetFilePath(Whois_textBox);
        }
        #endregion


        #region GUI Settings
        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    Check_button.Visible = true;
                    Sync_button.Visible = false;
                    Cutter_button.Visible = false;
                    ParseButton.Visible = false;
                    CancelButton.Visible = false;
                    WhoisStart_button.Visible = false;
                    WhoisCancel_button.Visible = false;
                    break;
                case 1:
                    Check_button.Visible = false;
                    Sync_button.Visible = true;
                    Cutter_button.Visible = true;
                    ParseButton.Visible = false;
                    CancelButton.Visible = false;
                    WhoisStart_button.Visible = false;
                    WhoisCancel_button.Visible = false;
                    break;
                case 2:
                    Check_button.Visible = false;
                    Sync_button.Visible = false;
                    Cutter_button.Visible = false;
                    ParseButton.Visible = true;
                    CancelButton.Visible = true;
                    WhoisStart_button.Visible = false;
                    WhoisCancel_button.Visible = false;
                    break;
                case 3:
                    Check_button.Visible = false;
                    Sync_button.Visible = false;
                    Cutter_button.Visible = false;
                    ParseButton.Visible = false;
                    CancelButton.Visible = false;
                    WhoisStart_button.Visible = true;
                    WhoisCancel_button.Visible = true;
                    break;
                default:
                    break;
            }
        }
        string getLeftTime(int timeout, int streamscount)
        {
            int siteleft = parsing_progressBar.Maximum - parsing_progressBar.Value;
            int timeleft = (siteleft * timeout) / streamscount;
            int minleft = timeleft / 60;
            return minleft.ToString() + " min.";
        }
        string getWhoisLeftTime(int timeout, int streamscount)
        {
            int siteleft = Whois_progressBar.Maximum - Whois_progressBar.Value;
            int timeleft = (siteleft * timeout) / streamscount;
            int minleft = timeleft / 60;
            return minleft.ToString() + " min.";
        }
        private void Domains_textbox_TextChanged(object sender, EventArgs e)
        {
            Domains_textbox.Text = Domains_textbox.Text;
        }
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
        private void Source_comboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Proxy_comboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void ProxyPort_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else e.Handled = true;
        }
        private void Source_comboBox_DropDownClosed(object sender, EventArgs e)
        {
            switch (Source_comboBox.SelectedIndex)
            {
                case 0:
                    parserequester = new BaseRequester();
                    break;
                case 1:
                    parserequester = new SpyMetricsRequester();
                    break;
                case 2:
                    parserequester = new AlexaRequester();
                    break;
                default:
                    break;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var item in threads)
            {
                if (item.IsAlive)
                    item.Abort();
            }
        }
        private void load_local_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (load_local_combobox.SelectedIndex)
            {
                case 0:
                    Check_Domains_list_textBox.Text = "http://marketing.yalantis.com/backlinks.csv";
                    isload = true;
                    break;
                case 1:
                    Check_Domains_list_textBox.Text = "";
                    isload = false;
                    break;
                default:
                    break;
            }
        }
        private void WhoisSource_comboBox_DropDownClosed(object sender, EventArgs e)
        {
            switch (WhoisSource_comboBox.SelectedIndex)
            {
                case 0:
                    //whoisrequester = new TheHostRequester();
                    break;
                case 1:
                    whoisrequester = new UkraineRequester();
                    break;
                default:
                    break;
            }

        }
        #endregion

    }
}
