using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Folder_Options
{
    public partial class DataGridWithVScrool : DataGridView
    {
        private const int CAPTIONHEIGHT = 20;
        private const int BORDERWIDTH = 2;
        public DataGridWithVScrool()
        {
            InitializeComponent();
            VerticalScrollBar.Visible = true;
            VerticalScrollBar.VisibleChanged += new EventHandler(ShowScrollBars);
        }

        private void ShowScrollBars(object sender, EventArgs e)
        {
            if (!VerticalScrollBar.Visible)
            {
                int width = VerticalScrollBar.Width;

                VerticalScrollBar.Location =
                new Point(ClientRectangle.Width - width - BORDERWIDTH, CAPTIONHEIGHT);

                VerticalScrollBar.Size =
                new Size(width, ClientRectangle.Height - CAPTIONHEIGHT - BORDERWIDTH);

                VerticalScrollBar.Show();
            }
        }
    }
}
