namespace Pars_tool
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
            this.components = new System.ComponentModel.Container();
            this.FilePath_textBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Alexa_radioButton = new System.Windows.Forms.RadioButton();
            this.SimilarWeb_radioButton = new System.Windows.Forms.RadioButton();
            this.parsing_progressBar = new System.Windows.Forms.ProgressBar();
            this.Proxy_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProxyHost_textbox = new System.Windows.Forms.TextBox();
            this.ProxyPort_textbox = new System.Windows.Forms.TextBox();
            this.Progress_Label = new System.Windows.Forms.Label();
            this.TimeLeft_label = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Time_Out_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Streams_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ParseButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.parsedResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Time_Out_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Streams_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parsedResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FilePath_textBox
            // 
            this.FilePath_textBox.Location = new System.Drawing.Point(12, 12);
            this.FilePath_textBox.Name = "FilePath_textBox";
            this.FilePath_textBox.Size = new System.Drawing.Size(220, 20);
            this.FilePath_textBox.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Proxy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Time-out";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Streams";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Alexa_radioButton);
            this.groupBox1.Controls.Add(this.SimilarWeb_radioButton);
            this.groupBox1.Location = new System.Drawing.Point(174, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(98, 69);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Site";
            // 
            // Alexa_radioButton
            // 
            this.Alexa_radioButton.AutoSize = true;
            this.Alexa_radioButton.Location = new System.Drawing.Point(7, 43);
            this.Alexa_radioButton.Name = "Alexa_radioButton";
            this.Alexa_radioButton.Size = new System.Drawing.Size(51, 17);
            this.Alexa_radioButton.TabIndex = 0;
            this.Alexa_radioButton.Text = "Alexa";
            this.Alexa_radioButton.UseVisualStyleBackColor = true;
            this.Alexa_radioButton.CheckedChanged += new System.EventHandler(this.Alexa_radioButton_CheckedChanged);
            // 
            // SimilarWeb_radioButton
            // 
            this.SimilarWeb_radioButton.AutoSize = true;
            this.SimilarWeb_radioButton.Location = new System.Drawing.Point(7, 20);
            this.SimilarWeb_radioButton.Name = "SimilarWeb_radioButton";
            this.SimilarWeb_radioButton.Size = new System.Drawing.Size(78, 17);
            this.SimilarWeb_radioButton.TabIndex = 0;
            this.SimilarWeb_radioButton.Text = "SimilarWeb";
            this.SimilarWeb_radioButton.UseVisualStyleBackColor = true;
            this.SimilarWeb_radioButton.CheckedChanged += new System.EventHandler(this.SimilarWeb_radioButton_CheckedChanged);
            // 
            // parsing_progressBar
            // 
            this.parsing_progressBar.Location = new System.Drawing.Point(65, 139);
            this.parsing_progressBar.Name = "parsing_progressBar";
            this.parsing_progressBar.Size = new System.Drawing.Size(167, 23);
            this.parsing_progressBar.TabIndex = 7;
            // 
            // Proxy_comboBox
            // 
            this.Proxy_comboBox.FormattingEnabled = true;
            this.Proxy_comboBox.Items.AddRange(new object[] {
            "Off",
            "On"});
            this.Proxy_comboBox.Location = new System.Drawing.Point(121, 66);
            this.Proxy_comboBox.Name = "Proxy_comboBox";
            this.Proxy_comboBox.Size = new System.Drawing.Size(40, 21);
            this.Proxy_comboBox.TabIndex = 9;
            this.Proxy_comboBox.Text = "Off";
            this.Proxy_comboBox.SelectedIndexChanged += new System.EventHandler(this.Proxy_comboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Server";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Port";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ProxyHost_textbox
            // 
            this.ProxyHost_textbox.Enabled = false;
            this.ProxyHost_textbox.Location = new System.Drawing.Point(12, 113);
            this.ProxyHost_textbox.Name = "ProxyHost_textbox";
            this.ProxyHost_textbox.Size = new System.Drawing.Size(102, 20);
            this.ProxyHost_textbox.TabIndex = 11;
            // 
            // ProxyPort_textbox
            // 
            this.ProxyPort_textbox.Enabled = false;
            this.ProxyPort_textbox.Location = new System.Drawing.Point(127, 113);
            this.ProxyPort_textbox.Name = "ProxyPort_textbox";
            this.ProxyPort_textbox.Size = new System.Drawing.Size(45, 20);
            this.ProxyPort_textbox.TabIndex = 11;
            this.ProxyPort_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PorttextBox_KeyPress);
            // 
            // Progress_Label
            // 
            this.Progress_Label.AutoSize = true;
            this.Progress_Label.Location = new System.Drawing.Point(122, 165);
            this.Progress_Label.Name = "Progress_Label";
            this.Progress_Label.Size = new System.Drawing.Size(0, 13);
            this.Progress_Label.TabIndex = 12;
            // 
            // TimeLeft_label
            // 
            this.TimeLeft_label.AutoSize = true;
            this.TimeLeft_label.Location = new System.Drawing.Point(236, 144);
            this.TimeLeft_label.Name = "TimeLeft_label";
            this.TimeLeft_label.Size = new System.Drawing.Size(0, 13);
            this.TimeLeft_label.TabIndex = 12;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Time_Out_numericUpDown
            // 
            this.Time_Out_numericUpDown.Location = new System.Drawing.Point(12, 67);
            this.Time_Out_numericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Time_Out_numericUpDown.Name = "Time_Out_numericUpDown";
            this.Time_Out_numericUpDown.Size = new System.Drawing.Size(35, 20);
            this.Time_Out_numericUpDown.TabIndex = 16;
            this.Time_Out_numericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Streams_numericUpDown
            // 
            this.Streams_numericUpDown.Location = new System.Drawing.Point(66, 67);
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
            this.Streams_numericUpDown.TabIndex = 16;
            this.Streams_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(92, 187);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(75, 23);
            this.ParseButton.TabIndex = 17;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Time left:";
            // 
            // parsedResultBindingSource
            // 
            this.parsedResultBindingSource.DataSource = typeof(Pars_tool.Class.ParsedResult);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 214);
            this.Controls.Add(this.ParseButton);
            this.Controls.Add(this.Streams_numericUpDown);
            this.Controls.Add(this.Time_Out_numericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TimeLeft_label);
            this.Controls.Add(this.Progress_Label);
            this.Controls.Add(this.ProxyPort_textbox);
            this.Controls.Add(this.ProxyHost_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Proxy_comboBox);
            this.Controls.Add(this.parsing_progressBar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilePath_textBox);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Outreach";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Time_Out_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Streams_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parsedResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FilePath_textBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Alexa_radioButton;
        private System.Windows.Forms.RadioButton SimilarWeb_radioButton;
        private System.Windows.Forms.ProgressBar parsing_progressBar;
        private System.Windows.Forms.ComboBox Proxy_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProxyHost_textbox;
        private System.Windows.Forms.TextBox ProxyPort_textbox;
        private System.Windows.Forms.Label Progress_Label;
        private System.Windows.Forms.Label TimeLeft_label;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NumericUpDown Time_Out_numericUpDown;
        private System.Windows.Forms.NumericUpDown Streams_numericUpDown;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.BindingSource parsedResultBindingSource;
        private System.Windows.Forms.Label label6;
    }
}

