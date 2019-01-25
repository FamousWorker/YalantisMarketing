using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Folder_Options
{
    public class SearchResultRow
    {
        Bitmap result;
        string name;
        public Bitmap Result
        {
            get { return result; }
            set { result = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
