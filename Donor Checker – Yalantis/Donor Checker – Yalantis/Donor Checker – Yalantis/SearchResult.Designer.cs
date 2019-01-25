namespace Folder_Options
{
    partial class SearchResult
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridWithVScrool1 = new Folder_Options.DataGridWithVScrool();
            this.Domains = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWithVScrool1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridWithVScrool1
            // 
            this.dataGridWithVScrool1.AllowUserToAddRows = false;
            this.dataGridWithVScrool1.AllowUserToDeleteRows = false;
            this.dataGridWithVScrool1.AllowUserToResizeColumns = false;
            this.dataGridWithVScrool1.AllowUserToResizeRows = false;
            this.dataGridWithVScrool1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridWithVScrool1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridWithVScrool1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWithVScrool1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Domains,
            this.Status});
            this.dataGridWithVScrool1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridWithVScrool1.Location = new System.Drawing.Point(0, 0);
            this.dataGridWithVScrool1.MinimumSize = new System.Drawing.Size(415, 150);
            this.dataGridWithVScrool1.MultiSelect = false;
            this.dataGridWithVScrool1.Name = "dataGridWithVScrool1";
            this.dataGridWithVScrool1.ReadOnly = true;
            this.dataGridWithVScrool1.RowHeadersVisible = false;
            this.dataGridWithVScrool1.Size = new System.Drawing.Size(415, 151);
            this.dataGridWithVScrool1.TabIndex = 1;
            // 
            // Domains
            // 
            this.Domains.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Domains.DataPropertyName = "name";
            this.Domains.Frozen = true;
            this.Domains.HeaderText = "Domains";
            this.Domains.Name = "Domains";
            this.Domains.ReadOnly = true;
            this.Domains.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Domains.Width = 350;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "result";
            this.Status.Frozen = true;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Status.Width = 45;
            // 
            // SearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 151);
            this.Controls.Add(this.dataGridWithVScrool1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SearchResult";
            this.Text = "Search Results";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWithVScrool1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridWithVScrool dataGridWithVScrool1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domains;
        private System.Windows.Forms.DataGridViewImageColumn Status;
    }
}