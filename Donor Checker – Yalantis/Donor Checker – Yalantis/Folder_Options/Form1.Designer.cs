namespace Folder_Options
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.load_local_combobox = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.Domains_textbox = new System.Windows.Forms.TextBox();
            this.Check_Domains_list_textBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Cutter_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Selector_5_comboBox = new System.Windows.Forms.ComboBox();
            this.Selector_1_comboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Selector_4_comboBox = new System.Windows.Forms.ComboBox();
            this.SavePath_textBox = new System.Windows.Forms.TextBox();
            this.Selector_3_comboBox = new System.Windows.Forms.ComboBox();
            this.Example_textBox = new System.Windows.Forms.TextBox();
            this.Selector_2_comboBox = new System.Windows.Forms.ComboBox();
            this.Selector_6_comboBox = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Source_comboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Progress_Label = new System.Windows.Forms.Label();
            this.TimeLeft_label = new System.Windows.Forms.Label();
            this.Da_pa_checkbox = new System.Windows.Forms.CheckBox();
            this.Cf_tf_checkbox = new System.Windows.Forms.CheckBox();
            this.Streams_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Time_Out_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label = new System.Windows.Forms.Label();
            this.ProxyPort_textbox = new System.Windows.Forms.TextBox();
            this.ProxyHost_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Proxy_comboBox = new System.Windows.Forms.ComboBox();
            this.parsing_progressBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Sourcelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ParseFilePath_textBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.WhoisSource_comboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.WhoisCountLeft_label = new System.Windows.Forms.Label();
            this.WhoisTimeLeft_label = new System.Windows.Forms.Label();
            this.WhoisStreams_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Whois_TimeOut_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.Whois_progressBar = new System.Windows.Forms.ProgressBar();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Whois_textBox = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ParseButton = new System.Windows.Forms.Button();
            this.Sync_button = new System.Windows.Forms.Button();
            this.Check_button = new System.Windows.Forms.Button();
            this.Cutter_button = new System.Windows.Forms.Button();
            this.WhoisStart_button = new System.Windows.Forms.Button();
            this.WhoisCancel_button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Streams_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time_Out_numericUpDown)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WhoisStreams_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Whois_TimeOut_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(7, 7);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(300, 235);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.load_local_combobox);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.Domains_textbox);
            this.tabPage1.Controls.Add(this.Check_Domains_list_textBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(292, 209);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Outreach";
            // 
            // load_local_combobox
            // 
            this.load_local_combobox.FormattingEnabled = true;
            this.load_local_combobox.Items.AddRange(new object[] {
            "HTTP",
            "Local"});
            this.load_local_combobox.Location = new System.Drawing.Point(3, 8);
            this.load_local_combobox.Name = "load_local_combobox";
            this.load_local_combobox.Size = new System.Drawing.Size(51, 21);
            this.load_local_combobox.TabIndex = 7;
            this.load_local_combobox.SelectedIndexChanged += new System.EventHandler(this.load_local_combobox_SelectedIndexChanged);
            this.load_local_combobox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Proxy_comboBox_KeyPress);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(256, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(32, 20);
            this.button5.TabIndex = 6;
            this.button5.Text = "...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Domains_textbox
            // 
            this.Domains_textbox.Location = new System.Drawing.Point(6, 35);
            this.Domains_textbox.Multiline = true;
            this.Domains_textbox.Name = "Domains_textbox";
            this.Domains_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Domains_textbox.Size = new System.Drawing.Size(282, 168);
            this.Domains_textbox.TabIndex = 4;
            this.Domains_textbox.TextChanged += new System.EventHandler(this.Domains_textbox_TextChanged);
            // 
            // Check_Domains_list_textBox
            // 
            this.Check_Domains_list_textBox.Location = new System.Drawing.Point(60, 9);
            this.Check_Domains_list_textBox.Name = "Check_Domains_list_textBox";
            this.Check_Domains_list_textBox.Size = new System.Drawing.Size(190, 20);
            this.Check_Domains_list_textBox.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(292, 209);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Data Sync";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Cutter_textbox);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(6, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 50);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Link cutter / Select a file (*.csv)";
            // 
            // Cutter_textbox
            // 
            this.Cutter_textbox.Location = new System.Drawing.Point(7, 19);
            this.Cutter_textbox.Name = "Cutter_textbox";
            this.Cutter_textbox.Size = new System.Drawing.Size(234, 20);
            this.Cutter_textbox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 20);
            this.button1.TabIndex = 4;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.cutterfilepath_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.Selector_5_comboBox);
            this.groupBox1.Controls.Add(this.Selector_1_comboBox);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.Selector_4_comboBox);
            this.groupBox1.Controls.Add(this.SavePath_textBox);
            this.groupBox1.Controls.Add(this.Selector_3_comboBox);
            this.groupBox1.Controls.Add(this.Example_textBox);
            this.groupBox1.Controls.Add(this.Selector_2_comboBox);
            this.groupBox1.Controls.Add(this.Selector_6_comboBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data sync / Select a file (*.csv)";
            // 
            // Selector_5_comboBox
            // 
            this.Selector_5_comboBox.FormattingEnabled = true;
            this.Selector_5_comboBox.Items.AddRange(new object[] {
            "",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P"});
            this.Selector_5_comboBox.Location = new System.Drawing.Point(167, 73);
            this.Selector_5_comboBox.Name = "Selector_5_comboBox";
            this.Selector_5_comboBox.Size = new System.Drawing.Size(32, 21);
            this.Selector_5_comboBox.TabIndex = 8;
            // 
            // Selector_1_comboBox
            // 
            this.Selector_1_comboBox.FormattingEnabled = true;
            this.Selector_1_comboBox.Items.AddRange(new object[] {
            "",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P"});
            this.Selector_1_comboBox.Location = new System.Drawing.Point(7, 73);
            this.Selector_1_comboBox.Name = "Selector_1_comboBox";
            this.Selector_1_comboBox.Size = new System.Drawing.Size(32, 21);
            this.Selector_1_comboBox.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 20);
            this.button2.TabIndex = 4;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(247, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 20);
            this.button3.TabIndex = 3;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Selector_4_comboBox
            // 
            this.Selector_4_comboBox.FormattingEnabled = true;
            this.Selector_4_comboBox.Items.AddRange(new object[] {
            "",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P"});
            this.Selector_4_comboBox.Location = new System.Drawing.Point(127, 73);
            this.Selector_4_comboBox.Name = "Selector_4_comboBox";
            this.Selector_4_comboBox.Size = new System.Drawing.Size(32, 21);
            this.Selector_4_comboBox.TabIndex = 9;
            // 
            // SavePath_textBox
            // 
            this.SavePath_textBox.Location = new System.Drawing.Point(7, 20);
            this.SavePath_textBox.Name = "SavePath_textBox";
            this.SavePath_textBox.Size = new System.Drawing.Size(234, 20);
            this.SavePath_textBox.TabIndex = 6;
            // 
            // Selector_3_comboBox
            // 
            this.Selector_3_comboBox.FormattingEnabled = true;
            this.Selector_3_comboBox.Items.AddRange(new object[] {
            "",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P"});
            this.Selector_3_comboBox.Location = new System.Drawing.Point(87, 73);
            this.Selector_3_comboBox.Name = "Selector_3_comboBox";
            this.Selector_3_comboBox.Size = new System.Drawing.Size(32, 21);
            this.Selector_3_comboBox.TabIndex = 10;
            // 
            // Example_textBox
            // 
            this.Example_textBox.Location = new System.Drawing.Point(7, 46);
            this.Example_textBox.Name = "Example_textBox";
            this.Example_textBox.Size = new System.Drawing.Size(234, 20);
            this.Example_textBox.TabIndex = 5;
            // 
            // Selector_2_comboBox
            // 
            this.Selector_2_comboBox.FormattingEnabled = true;
            this.Selector_2_comboBox.Items.AddRange(new object[] {
            "",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P"});
            this.Selector_2_comboBox.Location = new System.Drawing.Point(47, 73);
            this.Selector_2_comboBox.Name = "Selector_2_comboBox";
            this.Selector_2_comboBox.Size = new System.Drawing.Size(32, 21);
            this.Selector_2_comboBox.TabIndex = 11;
            // 
            // Selector_6_comboBox
            // 
            this.Selector_6_comboBox.FormattingEnabled = true;
            this.Selector_6_comboBox.Items.AddRange(new object[] {
            "",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P"});
            this.Selector_6_comboBox.Location = new System.Drawing.Point(207, 73);
            this.Selector_6_comboBox.Name = "Selector_6_comboBox";
            this.Selector_6_comboBox.Size = new System.Drawing.Size(32, 21);
            this.Selector_6_comboBox.TabIndex = 12;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.Source_comboBox);
            this.tabPage3.Controls.Add(this.tableLayoutPanel1);
            this.tabPage3.Controls.Add(this.Da_pa_checkbox);
            this.tabPage3.Controls.Add(this.Cf_tf_checkbox);
            this.tabPage3.Controls.Add(this.Streams_numericUpDown);
            this.tabPage3.Controls.Add(this.Time_Out_numericUpDown);
            this.tabPage3.Controls.Add(this.label);
            this.tabPage3.Controls.Add(this.ProxyPort_textbox);
            this.tabPage3.Controls.Add(this.ProxyHost_textbox);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.Proxy_comboBox);
            this.tabPage3.Controls.Add(this.parsing_progressBar);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.Sourcelabel);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.ParseFilePath_textBox);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(292, 209);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rank Parser";
            // 
            // Source_comboBox
            // 
            this.Source_comboBox.FormattingEnabled = true;
            this.Source_comboBox.Items.AddRange(new object[] {
            "Metrics",
            "SimilarWeb",
            "Alexa"});
            this.Source_comboBox.Location = new System.Drawing.Point(202, 83);
            this.Source_comboBox.Name = "Source_comboBox";
            this.Source_comboBox.Size = new System.Drawing.Size(80, 21);
            this.Source_comboBox.TabIndex = 75;
            this.Source_comboBox.DropDownClosed += new System.EventHandler(this.Source_comboBox_DropDownClosed);
            this.Source_comboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Source_comboBox_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.41072F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.58929F));
            this.tableLayoutPanel1.Controls.Add(this.Progress_Label, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.TimeLeft_label, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(65, 159);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(224, 13);
            this.tableLayoutPanel1.TabIndex = 74;
            // 
            // Progress_Label
            // 
            this.Progress_Label.AutoSize = true;
            this.Progress_Label.Dock = System.Windows.Forms.DockStyle.Right;
            this.Progress_Label.Location = new System.Drawing.Point(197, 0);
            this.Progress_Label.Name = "Progress_Label";
            this.Progress_Label.Size = new System.Drawing.Size(24, 13);
            this.Progress_Label.TabIndex = 66;
            this.Progress_Label.Text = "0/0";
            // 
            // TimeLeft_label
            // 
            this.TimeLeft_label.AutoSize = true;
            this.TimeLeft_label.Dock = System.Windows.Forms.DockStyle.Right;
            this.TimeLeft_label.Location = new System.Drawing.Point(4, 0);
            this.TimeLeft_label.Name = "TimeLeft_label";
            this.TimeLeft_label.Size = new System.Drawing.Size(32, 13);
            this.TimeLeft_label.TabIndex = 73;
            this.TimeLeft_label.Text = "0 min";
            // 
            // Da_pa_checkbox
            // 
            this.Da_pa_checkbox.AutoSize = true;
            this.Da_pa_checkbox.Location = new System.Drawing.Point(202, 127);
            this.Da_pa_checkbox.Name = "Da_pa_checkbox";
            this.Da_pa_checkbox.Size = new System.Drawing.Size(60, 17);
            this.Da_pa_checkbox.TabIndex = 72;
            this.Da_pa_checkbox.Text = "DA/PA";
            this.Da_pa_checkbox.UseVisualStyleBackColor = true;
            // 
            // Cf_tf_checkbox
            // 
            this.Cf_tf_checkbox.AutoSize = true;
            this.Cf_tf_checkbox.Location = new System.Drawing.Point(202, 109);
            this.Cf_tf_checkbox.Name = "Cf_tf_checkbox";
            this.Cf_tf_checkbox.Size = new System.Drawing.Size(57, 17);
            this.Cf_tf_checkbox.TabIndex = 72;
            this.Cf_tf_checkbox.Text = "CF/TF";
            this.Cf_tf_checkbox.UseVisualStyleBackColor = true;
            // 
            // Streams_numericUpDown
            // 
            this.Streams_numericUpDown.Location = new System.Drawing.Point(81, 83);
            this.Streams_numericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Streams_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Streams_numericUpDown.Name = "Streams_numericUpDown";
            this.Streams_numericUpDown.Size = new System.Drawing.Size(35, 20);
            this.Streams_numericUpDown.TabIndex = 69;
            this.Streams_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Time_Out_numericUpDown
            // 
            this.Time_Out_numericUpDown.Location = new System.Drawing.Point(14, 82);
            this.Time_Out_numericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Time_Out_numericUpDown.Name = "Time_Out_numericUpDown";
            this.Time_Out_numericUpDown.Size = new System.Drawing.Size(35, 20);
            this.Time_Out_numericUpDown.TabIndex = 68;
            this.Time_Out_numericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(14, 159);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(59, 13);
            this.label.TabIndex = 67;
            this.label.Text = "Time left:   ";
            // 
            // ProxyPort_textbox
            // 
            this.ProxyPort_textbox.Enabled = false;
            this.ProxyPort_textbox.Location = new System.Drawing.Point(133, 124);
            this.ProxyPort_textbox.Name = "ProxyPort_textbox";
            this.ProxyPort_textbox.Size = new System.Drawing.Size(45, 20);
            this.ProxyPort_textbox.TabIndex = 64;
            this.ProxyPort_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProxyPort_textbox_KeyPress);
            // 
            // ProxyHost_textbox
            // 
            this.ProxyHost_textbox.Enabled = false;
            this.ProxyHost_textbox.Location = new System.Drawing.Point(14, 124);
            this.ProxyHost_textbox.Name = "ProxyHost_textbox";
            this.ProxyHost_textbox.Size = new System.Drawing.Size(102, 20);
            this.ProxyHost_textbox.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Port";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Server";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Proxy_comboBox
            // 
            this.Proxy_comboBox.FormattingEnabled = true;
            this.Proxy_comboBox.Items.AddRange(new object[] {
            "Off",
            "On"});
            this.Proxy_comboBox.Location = new System.Drawing.Point(133, 82);
            this.Proxy_comboBox.Name = "Proxy_comboBox";
            this.Proxy_comboBox.Size = new System.Drawing.Size(40, 21);
            this.Proxy_comboBox.TabIndex = 61;
            this.Proxy_comboBox.Text = "Off";
            this.Proxy_comboBox.DropDownClosed += new System.EventHandler(this.Proxy_comboBox_SelectedIndexChanged);
            this.Proxy_comboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Proxy_comboBox_KeyPress);
            // 
            // parsing_progressBar
            // 
            this.parsing_progressBar.Location = new System.Drawing.Point(11, 176);
            this.parsing_progressBar.Name = "parsing_progressBar";
            this.parsing_progressBar.Size = new System.Drawing.Size(271, 23);
            this.parsing_progressBar.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Streams";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Time-out";
            // 
            // Sourcelabel
            // 
            this.Sourcelabel.AutoSize = true;
            this.Sourcelabel.Location = new System.Drawing.Point(199, 60);
            this.Sourcelabel.Name = "Sourcelabel";
            this.Sourcelabel.Size = new System.Drawing.Size(41, 13);
            this.Sourcelabel.TabIndex = 56;
            this.Sourcelabel.Text = "Source";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Proxy";
            // 
            // ParseFilePath_textBox
            // 
            this.ParseFilePath_textBox.Location = new System.Drawing.Point(11, 27);
            this.ParseFilePath_textBox.Name = "ParseFilePath_textBox";
            this.ParseFilePath_textBox.Size = new System.Drawing.Size(234, 20);
            this.ParseFilePath_textBox.TabIndex = 55;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(253, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 20);
            this.button4.TabIndex = 54;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.WhoisSource_comboBox);
            this.tabPage4.Controls.Add(this.tableLayoutPanel2);
            this.tabPage4.Controls.Add(this.WhoisStreams_numericUpDown);
            this.tabPage4.Controls.Add(this.Whois_TimeOut_numericUpDown);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.Whois_progressBar);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.Whois_textBox);
            this.tabPage4.Controls.Add(this.button6);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(292, 209);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Whois";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // WhoisSource_comboBox
            // 
            this.WhoisSource_comboBox.FormattingEnabled = true;
            this.WhoisSource_comboBox.Items.AddRange(new object[] {
            "TheHost",
            "Ukraine"});
            this.WhoisSource_comboBox.Location = new System.Drawing.Point(7, 78);
            this.WhoisSource_comboBox.Name = "WhoisSource_comboBox";
            this.WhoisSource_comboBox.Size = new System.Drawing.Size(80, 21);
            this.WhoisSource_comboBox.TabIndex = 94;
            this.WhoisSource_comboBox.DropDownClosed += new System.EventHandler(this.WhoisSource_comboBox_DropDownClosed);
            this.WhoisSource_comboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Source_comboBox_KeyPress);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.64151F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.35849F));
            this.tableLayoutPanel2.Controls.Add(this.WhoisCountLeft_label, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.WhoisTimeLeft_label, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(69, 131);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(216, 13);
            this.tableLayoutPanel2.TabIndex = 93;
            // 
            // WhoisCountLeft_label
            // 
            this.WhoisCountLeft_label.AutoSize = true;
            this.WhoisCountLeft_label.Dock = System.Windows.Forms.DockStyle.Right;
            this.WhoisCountLeft_label.Location = new System.Drawing.Point(189, 0);
            this.WhoisCountLeft_label.Name = "WhoisCountLeft_label";
            this.WhoisCountLeft_label.Size = new System.Drawing.Size(24, 13);
            this.WhoisCountLeft_label.TabIndex = 66;
            this.WhoisCountLeft_label.Text = "0/0";
            // 
            // WhoisTimeLeft_label
            // 
            this.WhoisTimeLeft_label.AutoSize = true;
            this.WhoisTimeLeft_label.Dock = System.Windows.Forms.DockStyle.Right;
            this.WhoisTimeLeft_label.Location = new System.Drawing.Point(13, 0);
            this.WhoisTimeLeft_label.Name = "WhoisTimeLeft_label";
            this.WhoisTimeLeft_label.Size = new System.Drawing.Size(32, 13);
            this.WhoisTimeLeft_label.TabIndex = 73;
            this.WhoisTimeLeft_label.Text = "0 min";
            // 
            // WhoisStreams_numericUpDown
            // 
            this.WhoisStreams_numericUpDown.Location = new System.Drawing.Point(243, 79);
            this.WhoisStreams_numericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.WhoisStreams_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WhoisStreams_numericUpDown.Name = "WhoisStreams_numericUpDown";
            this.WhoisStreams_numericUpDown.Size = new System.Drawing.Size(35, 20);
            this.WhoisStreams_numericUpDown.TabIndex = 90;
            this.WhoisStreams_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Whois_TimeOut_numericUpDown
            // 
            this.Whois_TimeOut_numericUpDown.Location = new System.Drawing.Point(176, 78);
            this.Whois_TimeOut_numericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Whois_TimeOut_numericUpDown.Name = "Whois_TimeOut_numericUpDown";
            this.Whois_TimeOut_numericUpDown.Size = new System.Drawing.Size(35, 20);
            this.Whois_TimeOut_numericUpDown.TabIndex = 89;
            this.Whois_TimeOut_numericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 88;
            this.label8.Text = "Time left:   ";
            // 
            // Whois_progressBar
            // 
            this.Whois_progressBar.Location = new System.Drawing.Point(7, 148);
            this.Whois_progressBar.Name = "Whois_progressBar";
            this.Whois_progressBar.Size = new System.Drawing.Size(271, 23);
            this.Whois_progressBar.TabIndex = 82;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(233, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 81;
            this.label11.Text = "Streams";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(162, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 80;
            this.label12.Text = "Time-out";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 79;
            this.label13.Text = "Source";
            // 
            // Whois_textBox
            // 
            this.Whois_textBox.Location = new System.Drawing.Point(7, 23);
            this.Whois_textBox.Name = "Whois_textBox";
            this.Whois_textBox.Size = new System.Drawing.Size(234, 20);
            this.Whois_textBox.TabIndex = 77;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(249, 23);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(32, 20);
            this.button6.TabIndex = 76;
            this.button6.Text = "...";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CancelButton
            // 
            this.CancelButton.Enabled = false;
            this.CancelButton.Location = new System.Drawing.Point(176, 248);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(60, 23);
            this.CancelButton.TabIndex = 54;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Visible = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(87, 248);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(60, 23);
            this.ParseButton.TabIndex = 55;
            this.ParseButton.Text = "Start";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Visible = false;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // Sync_button
            // 
            this.Sync_button.Location = new System.Drawing.Point(243, 248);
            this.Sync_button.Name = "Sync_button";
            this.Sync_button.Size = new System.Drawing.Size(60, 23);
            this.Sync_button.TabIndex = 56;
            this.Sync_button.Text = "Sync";
            this.Sync_button.UseVisualStyleBackColor = true;
            this.Sync_button.Visible = false;
            this.Sync_button.Click += new System.EventHandler(this.sync_button_Click_1);
            // 
            // Check_button
            // 
            this.Check_button.Location = new System.Drawing.Point(76, 248);
            this.Check_button.Name = "Check_button";
            this.Check_button.Size = new System.Drawing.Size(60, 23);
            this.Check_button.TabIndex = 57;
            this.Check_button.Text = "Check";
            this.Check_button.UseVisualStyleBackColor = true;
            this.Check_button.Click += new System.EventHandler(this.check_button_Click);
            // 
            // Cutter_button
            // 
            this.Cutter_button.Location = new System.Drawing.Point(177, 248);
            this.Cutter_button.Name = "Cutter_button";
            this.Cutter_button.Size = new System.Drawing.Size(60, 23);
            this.Cutter_button.TabIndex = 56;
            this.Cutter_button.Text = "Cut off";
            this.Cutter_button.UseVisualStyleBackColor = true;
            this.Cutter_button.Visible = false;
            this.Cutter_button.Click += new System.EventHandler(this.cut_button_Click_1);
            // 
            // WhoisStart_button
            // 
            this.WhoisStart_button.Location = new System.Drawing.Point(42, 248);
            this.WhoisStart_button.Name = "WhoisStart_button";
            this.WhoisStart_button.Size = new System.Drawing.Size(60, 23);
            this.WhoisStart_button.TabIndex = 56;
            this.WhoisStart_button.Text = "Start";
            this.WhoisStart_button.UseVisualStyleBackColor = true;
            this.WhoisStart_button.Visible = false;
            this.WhoisStart_button.Click += new System.EventHandler(this.Whoisstart_button_Click_1);
            // 
            // WhoisCancel_button
            // 
            this.WhoisCancel_button.Enabled = false;
            this.WhoisCancel_button.Location = new System.Drawing.Point(156, 248);
            this.WhoisCancel_button.Name = "WhoisCancel_button";
            this.WhoisCancel_button.Size = new System.Drawing.Size(60, 23);
            this.WhoisCancel_button.TabIndex = 56;
            this.WhoisCancel_button.Text = "Cancel";
            this.WhoisCancel_button.UseVisualStyleBackColor = true;
            this.WhoisCancel_button.Visible = false;
            this.WhoisCancel_button.Click += new System.EventHandler(this.WhoisCansel_button_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P"});
            this.comboBox1.Location = new System.Drawing.Point(247, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(32, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 76;
            this.label6.Text = "Select a file (*.csv)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 281);
            this.Controls.Add(this.Check_button);
            this.Controls.Add(this.WhoisCancel_button);
            this.Controls.Add(this.WhoisStart_button);
            this.Controls.Add(this.Cutter_button);
            this.Controls.Add(this.Sync_button);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ParseButton);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yalantis Marketing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Streams_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time_Out_numericUpDown)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WhoisStreams_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Whois_TimeOut_numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox Domains_textbox;
        private System.Windows.Forms.TextBox Check_Domains_list_textBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox Selector_1_comboBox;
        private System.Windows.Forms.ComboBox Selector_5_comboBox;
        private System.Windows.Forms.ComboBox Selector_4_comboBox;
        private System.Windows.Forms.ComboBox Selector_3_comboBox;
        private System.Windows.Forms.ComboBox Selector_2_comboBox;
        private System.Windows.Forms.ComboBox Selector_6_comboBox;
        private System.Windows.Forms.TextBox Example_textBox;
        private System.Windows.Forms.TextBox SavePath_textBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown Streams_numericUpDown;
        private System.Windows.Forms.NumericUpDown Time_Out_numericUpDown;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label Progress_Label;
        private System.Windows.Forms.TextBox ProxyPort_textbox;
        private System.Windows.Forms.TextBox ProxyHost_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Proxy_comboBox;
        private System.Windows.Forms.ProgressBar parsing_progressBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ParseFilePath_textBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.Button Sync_button;
        private System.Windows.Forms.Button Check_button;
        private System.Windows.Forms.CheckBox Da_pa_checkbox;
        private System.Windows.Forms.CheckBox Cf_tf_checkbox;
        private System.Windows.Forms.Label TimeLeft_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Cutter_textbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Cutter_button;
        private System.Windows.Forms.ComboBox load_local_combobox;
        private System.Windows.Forms.ComboBox Source_comboBox;
        private System.Windows.Forms.Label Sourcelabel;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox WhoisSource_comboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label WhoisCountLeft_label;
        private System.Windows.Forms.Label WhoisTimeLeft_label;
        private System.Windows.Forms.NumericUpDown WhoisStreams_numericUpDown;
        private System.Windows.Forms.NumericUpDown Whois_TimeOut_numericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar Whois_progressBar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Whois_textBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button WhoisStart_button;
        private System.Windows.Forms.Button WhoisCancel_button;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
    }
}

